using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MOM.Application.DTOs.Account.Responses;
using MOM.Application.Infrastructure.Extensions;
using MOM.Application.Infrastructure.Settings;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MOM.Application.Features.Personnel.Commands.Authentication
{
    public class AuthenticationCommandHandler(IPersonRepository personRepository, IPersonnelClassPermissionRepository personnelClassPermissionRepository, IOrgPermissionRepository orgPermissionRepository, ITranslator translator, JwtSettings jwtSettings, IUnitOfWork unitOfWork) : IRequestHandler<AuthenticationCommand, BaseResult<AuthenticationResponse>>
    {
        public async Task<BaseResult<AuthenticationResponse>> Handle(AuthenticationCommand request, CancellationToken cancellationToken)
        {
            var user = await personRepository.DbSet
                .Include(m => m.DefinedBy)
                .ThenInclude(d => d.Target)
                .ThenInclude(t => t.Permissions)
                .Include(m => m.HierarchyScopeRel)
                .ThenInclude(t => t.Permissions)
                .Include(m => m.AvailablePermissions)
                .Where(m => m.Id.Equals(request.UserName) || m.ContactInformation.Email.Equals(request.UserName) || m.ContactInformation.PhoneNumber.Equals(request.UserName))
                .FirstOrDefaultAsync();
            if (user == null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.AccountMessages.TheUserNameOrPasswordIsIncorrect));
            }
            string passWord = request.Password.Sha1Signature(user.DtId.ToString());

            if (!user.PassWord.Equals(passWord))
            {
                user.FailedCount++;
                if (user.FailedCount >= 5)
                {
                    user.LockoutOnFailure = true;
                    user.LockoutDateTime = DateTime.UtcNow;
                    return new Error(ErrorCode.FieldDataInvalid, translator.GetString(TranslatorMessages.AccountMessages.AccountLockoutOnFailure()));
                }
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.AccountMessages.TheUserNameOrPasswordIsIncorrect));
            }
            if (user.LockoutOnFailure)
            {
                var lockoutDuration = DateTime.UtcNow - user.LockoutDateTime.Value;
                if (lockoutDuration.TotalMinutes < 30)
                {
                    return new Error(ErrorCode.FieldDataInvalid, translator.GetString(TranslatorMessages.AccountMessages.AccountLockoutOnFailure()));
                }
                else
                {
                    user.LockoutOnFailure = false;
                    user.LockoutDateTime = null;
                }
            }
            user.SecurityStamp = Guid.NewGuid().ToString();

            var returnModel = await GetAuthenticationResponse(user);
            await unitOfWork.SaveChangesAsync();
            return returnModel;
        }

        private async Task<AuthenticationResponse> GetAuthenticationResponse(Person user)
        {
            var personnelClassPermissionList = user.DefinedBy.Select(d => d.Target.Permissions.Select(t => t.MenuButtonId)).SelectMany(t => t).ToList();
            //personnelClassPermissionList.AddRange(user.HierarchyScopeRel.Permissions.Select(t => t.MenuButtonId).ToList());
            //personnelClassPermissionList.AddRange(user.AvailablePermissions.Where(m => m.Available).Select(m => m.MenuButtonId).ToList());

            List<string> rolesList = personnelClassPermissionList.Except(user.AvailablePermissions.Where(m => m.Available = false).Select(m => m.MenuButtonId)).Distinct().ToList();

            var jwToken = GenerateJwtToken();

            return new AuthenticationResponse()
            {
                JwToken = jwToken,
                Email = user.ContactInformation.Email,
                EmployeeNumber = user.Id,
                Name = user.Name,
                Photo = user.Photo,
                Roles = rolesList
            };

            string GenerateJwtToken()
            {
                string? iss = jwtSettings.Issuer;
                string? aud = jwtSettings.Audience;

                var claims = new List<Claim> {
                    new(JwtRegisteredClaimNames.Iss,iss),
                    new(JwtRegisteredClaimNames.Aud,aud),
                    new(ClaimTypes.NameIdentifier,user.DtId.ToString()),
                    new ("Roles",string.Join(",",rolesList)),
                    new Claim("SecurityStamp", user.SecurityStamp),
                };

                var credentials = new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Key)),
                    SecurityAlgorithms.HmacSha256
                );

                SecurityToken securityToken = new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(jwtSettings.DurationInMinutes),//过期时间
                    signingCredentials: credentials
                );
                //生成jwt令牌
                return new JwtSecurityTokenHandler().WriteToken(securityToken);
            }
        }
    }
}
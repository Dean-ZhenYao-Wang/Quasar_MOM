using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using MOM.Application.DTOs.Account.Responses;
using MOM.Application.Features.Personnel.Commands.UpdatePerson;
using MOM.Application.Features.Personnel.Settings;
using MOM.Application.Infrastructure.Extensions;
using MOM.Application.Infrastructure.Services;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static OrchardCore.OrchardCoreConstants;

namespace MOM.Application.Features.Personnel.Commands
{
    public class ChangePasswordCommandHandler(ITranslator translator, IPersonRepository personRepository, IAuthenticatedUserService authenticated) : IRequestHandler<ChangePasswordCommand, BaseResult>
    {
        public async Task<BaseResult> Handle(ChangePasswordCommand request, CancellationToken cancellationToken)
        {
            Guid dtId = Guid.Parse(authenticated.DtId);
            var user = await personRepository.GetByIdAsync(dtId);
            string newPassWord = request.Password.Sha1Signature(authenticated.DtId);
            if (user.PassWord.Equals(newPassWord))
            {
                user.PassWord = newPassWord;
                user.SecurityStamp = Guid.NewGuid().ToString();
            }
            return BaseResult.Ok();
        }
    }
    public class AuthenticationCommandHandler(IPersonRepository personRepository, ITranslator translator, JwtSettings jwtSettings) : IRequestHandler<AuthenticationCommand, BaseResult<AuthenticationResponse>>
    {
        public async Task<BaseResult<AuthenticationResponse>> Handle(AuthenticationCommand request, CancellationToken cancellationToken)
        {
            var user = await personRepository.FindByNameAsync(request.UserName);
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
            return await GetAuthenticationResponse(user);
        }
        private async Task<AuthenticationResponse> GetAuthenticationResponse(Person user)
        {
            var jwToken = await GenerateJwtToken();

            var rolesList = new List<string>();
            //await userManager.GetRolesAsync(user);

            return new AuthenticationResponse()
            {
                JwToken = jwToken,
                Email = user.Email,
                UserName = user.Id,
                Roles = rolesList
            };

            async Task<string> GenerateJwtToken()
            {
                //秘钥，就是标头，这里用Hmacsha256算法，需要256bit的密钥
                var securityKey = new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtSettings.Key)), SecurityAlgorithms.HmacSha256);
                var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Key));
                var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

                var claims = new Claim[] {
                    new(JwtRegisteredClaimNames.Iss,jwtSettings.Issuer),
                    new(JwtRegisteredClaimNames.Aud,jwtSettings.Audience),
                    new(ClaimTypes.NameIdentifier,user.DtId.ToString()),
                    new Claim("SecurityStamp", user.SecurityStamp)
                };

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(claims),
                    Expires = DateTime.UtcNow.AddMinutes(jwtSettings.DurationInMinutes),
                    Issuer = jwtSettings.Issuer,
                    Audience = jwtSettings.Audience,
                    SigningCredentials = signingCredentials
                };

                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }
        }
    }
}

using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using MOM.Application.DTOs.Account.Responses;
using MOM.Application.Features.Personnel.Commands.UpdatePerson;
using MOM.Application.Features.Personnel.Settings;
using MOM.Application.Infrastructure.Extensions;
using MOM.Application.Interfaces;
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

namespace MOM.Application.Features.Personnel.Commands.Authentication
{
    public class AuthenticationCommandHandler(IPersonRepository personRepository, ITranslator translator, JwtSettings jwtSettings, IUnitOfWork unitOfWork) : IRequestHandler<AuthenticationCommand, BaseResult<AuthenticationResponse>>
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
            user.SecurityStamp = Guid.NewGuid().ToString();

            var returnModel = GetAuthenticationResponse(user);
            await unitOfWork.SaveChangesAsync();
            return returnModel;
        }
        private AuthenticationResponse GetAuthenticationResponse(Person user)
        {
            var jwToken = GenerateJwtToken();

            var rolesList = new List<string>();

            return new AuthenticationResponse()
            {
                JwToken = jwToken,
                Email = user.Email,
                UserName = user.Id,
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
                    new Claim("SecurityStamp", user.SecurityStamp),
                };
                user.GetDefinedBy().ForEach(m =>
                {
                    claims.Add(new Claim(ClaimTypes.Role, m));
                });

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

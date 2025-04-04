using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MOM.Application.DTOs.Account.Requests;
using MOM.Application.DTOs.Account.Responses;
using MOM.Application.DTOs.Personnel.Requests;
using MOM.Application.Features.Personnel.Commands.AddPerson;
using MOM.Application.Infrastructure.Services;
using MOM.Application.Interfaces.Interfaces.UserInterfaces;
using MOM.Application.Wrappers;
using MOM.Infrastructure.Identity.Contexts;
using MOM.Infrastructure.Identity.Models;
using MOM.Infrastructure.Identity.Settings;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Infrastructure.Identity.Services
{
    public class AccountServices(UserManager<ApplicationUser> userManager, IAuthenticatedUserService authenticatedUser, SignInManager<ApplicationUser> signInManager, JwtSettings jwtSettings, ITranslator translator, IMediator _mediator, IdentityContext identityContext) : IAccountServices
    {
        protected IMediator Mediator => _mediator;
        public async Task<BaseResult> ChangePassword(ChangePasswordRequest model)
        {
            var user = await userManager.FindByIdAsync(authenticatedUser.UserId);

            var token = await userManager.GeneratePasswordResetTokenAsync(user!);
            var identityResult = await userManager.ResetPasswordAsync(user, token, model.Password);

            if (identityResult.Succeeded)
                return BaseResult.Ok();

            return identityResult.Errors.Select(p => new Error(ErrorCode.ErrorInIdentity, p.Description)).ToList();
        }

        public async Task<BaseResult> ChangeUserName(ChangeUserNameRequest model)
        {
            var user = await userManager.FindByIdAsync(authenticatedUser.UserId);

            user.UserName = model.UserName;

            var identityResult = await userManager.UpdateAsync(user);

            if (identityResult.Succeeded)
                return BaseResult.Ok();

            return identityResult.Errors.Select(p => new Error(ErrorCode.ErrorInIdentity, p.Description)).ToList();
        }

        public async Task<BaseResult<AuthenticationResponse>> Authenticate(AuthenticationRequest request)
        {
            var user = await userManager.FindByNameAsync(request.UserName);
            if (user == null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.AccountMessages.Account_NotFound_with_UserName(request.UserName)), nameof(request.UserName));
            }

            var signInResult = await signInManager.PasswordSignInAsync(user.UserName, request.Password, false, lockoutOnFailure: false);
            if (!signInResult.Succeeded)
            {
                return new Error(ErrorCode.FieldDataInvalid, translator.GetString(TranslatorMessages.AccountMessages.Invalid_password()), nameof(request.Password));
            }

            return await GetAuthenticationResponse(user);
        }

        public async Task<BaseResult<AuthenticationResponse>> AuthenticateByUserName(string username)
        {
            var user = await userManager.FindByNameAsync(username);
            if (user == null)
            {
                return new Error(ErrorCode.NotFound, translator.GetString(TranslatorMessages.AccountMessages.Account_NotFound_with_UserName(username)), nameof(username));
            }

            return await GetAuthenticationResponse(user);
        }

        public async Task<BaseResult<string>> RegisterGhostAccount()
        {
            var user = new ApplicationUser()
            {
                UserName = GenerateRandomString(7)
            };

            var identityResult = await userManager.CreateAsync(user);

            if (identityResult.Succeeded)
            {
                await Mediator.Send(new AddPersonCommand() { DtId = user.Id, Id = user.UserName, Name = user.NormalizedUserName == null ? user.Name : user.NormalizedUserName });
                return user.UserName;
            }

            return identityResult.Errors.Select(p => new Error(ErrorCode.ErrorInIdentity, p.Description)).ToList();

            string GenerateRandomString(int length)
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                var random = new Random();
                return new string(Enumerable.Repeat(chars, length)
                        .Select(s => s[random.Next(s.Length)]).ToArray());
            }
        }

        private async Task<AuthenticationResponse> GetAuthenticationResponse(ApplicationUser user)
        {
            await userManager.UpdateSecurityStampAsync(user);

            var jwToken = await GenerateJwtToken();

            var rolesList = await userManager.GetRolesAsync(user);

            return new AuthenticationResponse()
            {
                Id = user.Id.ToString(),
                JwToken = new JwtSecurityTokenHandler().WriteToken(jwToken),
                Email = user.Email,
                UserName = user.UserName,
                Roles = rolesList,
                IsVerified = user.EmailConfirmed,
            };

            async Task<JwtSecurityToken> GenerateJwtToken()
            {
                var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Key));
                var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

                return new JwtSecurityToken(
                    issuer: jwtSettings.Issuer,
                    audience: jwtSettings.Audience,
                    claims: (await signInManager.ClaimsFactory.CreateAsync(user)).Claims,
                    expires: DateTime.UtcNow.AddMinutes(jwtSettings.DurationInMinutes),
                    signingCredentials: signingCredentials);
            }
        }
        public async Task<BaseResult> AddAccountAsync(Guid userId, string UserName, string NormalizedUserName, string? Email, string? PhoneNumber, IEnumerable<Guid>? PositionDtId_List)
        {
            var user = new ApplicationUser
            {
                Id = userId,
                UserName = UserName,
                NormalizedUserName = NormalizedUserName,
                Email = Email,
                PhoneNumber = PhoneNumber,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            await userManager.CreateAsync(user, "Sam@12345");
            if (PositionDtId_List != null && PositionDtId_List.Count() > 0)
            {
                foreach (var role in PositionDtId_List)
                {
                    await userManager.AddToRoleAsync(user, role.ToString());
                }
            }
            return BaseResult.Ok();
        }

        public async Task DeleteAccountAsync(IEnumerable<Guid> enumerable)
        {
            await identityContext.Users.Where(m => enumerable.Contains(m.Id)).ExecuteDeleteAsync();
        }

        public async Task UpdateAccountAsync(UpdatePersonRequest request)
        {
            Guid userId = request.DtId;
            await userManager.Users.Where(m => m.Id.Equals(userId))
                .ExecuteUpdateAsync(m => m.SetProperty(p => p.UserName, request.Id)
                .SetProperty(p => p.NormalizedUserName, request.Name)
                .SetProperty(p => p.Email, request.Email)
                .SetProperty(p => p.PhoneNumber, request.PhoneNumber));

            var oldHaveRoleIds = await identityContext.UserRoles.Where(m => m.UserId.Equals(userId)).Select(m => m.RoleId).ToListAsync();
            var requestRoleIds = request.PositionDtId_List;
            var notHaveRoleIds = requestRoleIds.Except(oldHaveRoleIds);
            var deleteRoleIds = oldHaveRoleIds.Except(requestRoleIds);
            await identityContext.UserRoles.Where(m => m.UserId.Equals(userId) && deleteRoleIds.Contains(m.RoleId)).ExecuteDeleteAsync();
            List<IdentityUserRole<Guid>> addList = notHaveRoleIds.Select(m => new IdentityUserRole<Guid>() { UserId = userId, RoleId = m }).ToList();
            await identityContext.UserRoles.AddRangeAsync(addList);
            await identityContext.SaveChangesAsync();
        }
    }
}

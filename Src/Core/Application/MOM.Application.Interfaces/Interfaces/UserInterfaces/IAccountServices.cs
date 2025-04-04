using MOM.Application.DTOs.Account.Requests;
using MOM.Application.DTOs.Account.Responses;
using MOM.Application.DTOs.Personnel.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Interfaces.Interfaces.UserInterfaces
{
    public interface IAccountServices
    {
        Task<BaseResult<string>> RegisterGhostAccount();
        Task<BaseResult> ChangePassword(ChangePasswordRequest model);
        Task<BaseResult> ChangeUserName(ChangeUserNameRequest model);
        Task<BaseResult<AuthenticationResponse>> Authenticate(AuthenticationRequest request);
        Task<BaseResult<AuthenticationResponse>> AuthenticateByUserName(string username);
        Task<BaseResult> AddAccountAsync(Guid userId, string UserName,string NormalizedUserName,string? Email,string? PhoneNumber, IEnumerable<Guid>? PositionDtId_List);
        Task DeleteAccountAsync(IEnumerable<Guid> enumerable);
        Task UpdateAccountAsync(UpdatePersonRequest command);
    }
}

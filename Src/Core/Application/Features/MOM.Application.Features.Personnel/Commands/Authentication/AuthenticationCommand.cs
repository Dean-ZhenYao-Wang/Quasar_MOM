using MediatR;
using MOM.Application.DTOs.Account.Requests;
using MOM.Application.DTOs.Account.Responses;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Personnel.Commands.Authentication
{
    /// <summary>
    ///
    /// </summary>
    public class AuthenticationCommand : AuthenticationRequest, IRequest<BaseResult<AuthenticationResponse>>
    {
    }
}
using MediatR;
using MOM.Application.DTOs.Account.Requests;
using MOM.Application.Wrappers;

namespace MOM.Application.Features.Personnel.Commands.ChangePassword
{
    public class ChangePasswordCommand : ChangePasswordRequest, IRequest<BaseResult>
    {
    }
}
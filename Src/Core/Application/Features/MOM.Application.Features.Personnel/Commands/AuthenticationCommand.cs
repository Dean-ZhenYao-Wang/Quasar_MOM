using MediatR;
using MOM.Application.DTOs.Account.Requests;
using MOM.Application.DTOs.Account.Responses;
using MOM.Application.DTOs.Personnel.Requests;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.Personnel.Commands
{
    public class AuthenticationCommand : AuthenticationRequest, IRequest<BaseResult<AuthenticationResponse>>
    {
    }
    public class ChangePasswordCommand : ChangePasswordRequest, IRequest<BaseResult>
    {
    }
}

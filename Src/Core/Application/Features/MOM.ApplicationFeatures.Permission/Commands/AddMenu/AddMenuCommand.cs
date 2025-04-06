using MediatR;
using MOM.Application.DTOs.Menu.Requests;
using MOM.Application.Wrappers;
using MOM.Domain.Permission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.ApplicationFeatures.Permission.Commands.AddMenu
{
    public class AddMenuCommand : AddMenuRequest, IRequest<BaseResult>
    {
        
    }
}

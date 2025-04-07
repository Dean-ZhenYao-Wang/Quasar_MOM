using MediatR;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.Permission.Commands.DeleteMenu
{
    public class DeleteMenuCommand:IRequest<BaseResult>
    {
        public Guid[] DtIds { get; set; }
    }
}

using MediatR;
using MOM.Application.DTOs.Common;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.Material.Commands.DeleteMaterialDefinition
{
    public class DeleteMaterialDefinitionCommand : DeleteCommand, IRequest<BaseResult>
    {
    }
}

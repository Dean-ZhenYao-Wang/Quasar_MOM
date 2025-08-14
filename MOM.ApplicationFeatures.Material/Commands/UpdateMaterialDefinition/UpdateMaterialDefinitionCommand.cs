using MediatR;
using MOM.Application.DTOs.MaterialClass.Requests;
using MOM.Application.DTOs.MaterialDefinition.Requests;
using MOM.Application.DTOs.PhysicalAssetAndEquipment.Requests;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.Material.Commands.UpdateMaterialDefinition
{
    public class UpdateMaterialDefinitionCommand: UpdateMaterialDefinitionRequest, IRequest<BaseResult>
    {
    }
}

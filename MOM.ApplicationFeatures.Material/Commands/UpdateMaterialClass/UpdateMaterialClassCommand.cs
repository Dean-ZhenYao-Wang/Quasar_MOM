using MediatR;
using MOM.Application.DTOs.MaterialClass.Requests;
using MOM.Application.DTOs.PhysicalAssetAndEquipment.Requests;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.Material.Commands.UpdateMaterialClass
{
    public class UpdateMaterialClassCommand:UpdateMaterialClassRequest,IRequest<BaseResult>
    {
    }
}

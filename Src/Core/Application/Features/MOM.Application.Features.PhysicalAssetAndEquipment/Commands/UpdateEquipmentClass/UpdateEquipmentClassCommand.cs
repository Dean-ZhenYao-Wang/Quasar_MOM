using MediatR;
using MOM.Application.DTOs.PhysicalAssetAndEquipment.Requests;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.PhysicalAssetAndEquipment.Commands.UpdateEquipmentClass
{
    public class UpdateEquipmentClassCommand:UpdateEquipmentClassRequest,IRequest<BaseResult>
    {
    }
}

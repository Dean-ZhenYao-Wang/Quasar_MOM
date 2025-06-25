using MediatR;
using MOM.Application.DTOs.PhysicalAssetAndEquipment.Requests;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.PhysicalAssetAndEquipment.Commands.AddEquipmentClass
{
    public class AddEquipmentClassCommand : AddEquipmentClassRequest, IRequest<BaseResult>
    {
    }
}

using MediatR;
using MOM.Application.DTOs.Common;
using MOM.Application.Features.PhysicalAssetAndEquipment.Commands.DeleteEquipmentClass;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.PhysicalAssetAndEquipment.Commands.DeleteEquipment
{
    public class DeleteEquipmentCommand : DeleteCommand, IRequest<BaseResult>
    {
    }
}

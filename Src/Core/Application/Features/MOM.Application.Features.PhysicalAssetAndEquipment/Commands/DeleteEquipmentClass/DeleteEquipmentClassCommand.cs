using MediatR;
using MOM.Application.DTOs.Common;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.PhysicalAssetAndEquipment.Commands.DeleteEquipmentClass
{
    public class DeleteEquipmentClassCommand : DeleteCommand, IRequest<BaseResult>
    {
    }
}

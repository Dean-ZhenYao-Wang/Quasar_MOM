using MediatR;
using MOM.Application.Features.PhysicalAssetAndEquipment.Queries.GetPagedEquipmentClass;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment;

namespace MOM.Application.Features.PhysicalAssetAndEquipment.Queries.GetIsMadeUpOf
{
    public class GetEquipmentClassIsMadeUpOfQuery :PaginationRequestParameter, IRequest<PagedResponse<EquipmentClass>>
    {
        /// <summary>
        /// 设备类型的DTId
        /// </summary>
        public Guid DtId { get; set; }
    }
}
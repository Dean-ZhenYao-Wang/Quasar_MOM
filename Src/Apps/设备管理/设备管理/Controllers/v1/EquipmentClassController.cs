using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOM.Application.Features.PhysicalAssetAndEquipment.Queries.GetIncludesRelations;
using MOM.Application.Features.PhysicalAssetAndEquipment.Queries.GetIsMadeUpOf;
using MOM.Application.Features.PhysicalAssetAndEquipment.Queries.GetPagedEquipmentClass;
using MOM.Application.Infrastructure;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment;

namespace 设备管理.Controllers.v1
{
    [Tags("设备类管理")]
    [ApiVersion("1")]
    public sealed class EquipmentClassController : BaseApiController
    {
        /// <summary>
        /// 查询设备类型列表
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet(nameof(GetPagedEquipmentClass))]
        public async Task<PagedResponse<EquipmentClass>> GetPagedEquipmentClass([FromQuery] GetPagedEquipmentClassQuery query)
        {
            return await Mediator.Send(query);
        }
        /// <summary>
        /// 查询包含关系的设备类型
        /// </summary>
        /// <param name="dtId"></param>
        /// <returns></returns>
        [HttpGet("/api/v{version:apiVersion}/[controller]/{dtId}/[action]")]
        public async Task<List<EquipmentClass>> IncludesRelations(Guid dtId)
        {
            var query = new GetEquipmentClassIncludesRelationsQuery()
            {
                DtId = dtId
            };
            return await Mediator.Send(query);
        }
        /// <summary>
        /// 查询组合关系的设备类型
        /// </summary>
        /// <param name="dtId"></param>
        /// <returns></returns>
        [HttpGet("/api/v{version:apiVersion}/[controller]/{dtId}/[action]")]
        public async Task<List<EquipmentClass>> IsMadeUpOf(Guid dtId)
        {
            var query = new GetEquipmentClassIsMadeUpOfQuery()
            {
                DtId = dtId
            };
            return await Mediator.Send(query);
        }
    }
}
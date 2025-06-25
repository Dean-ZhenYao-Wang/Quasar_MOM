using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOM.Application.Features.PhysicalAssetAndEquipment.Commands.AddEquipmentClass;
using MOM.Application.Features.PhysicalAssetAndEquipment.Commands.DeleteEquipmentClass;
using MOM.Application.Features.PhysicalAssetAndEquipment.Commands.UpdateEquipmentClass;
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
        [HttpGet]
        public async Task<PagedResponse<EquipmentClass>> GetPagedEquipmentClass([FromQuery] GetPagedEquipmentClassQuery query)
        {
            return await Mediator.Send(query);
        }
        /// <summary>
        /// 查询包含关系的设备类型
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<PagedResponse<EquipmentClass>> IncludesRelations([FromQuery] GetEquipmentClassIncludesRelationsQuery query)
        {
            return await Mediator.Send(query);
        }
        /// <summary>
        /// 查询组合关系的设备类型
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<PagedResponse<EquipmentClass>> IsMadeUpOf([FromQuery] GetEquipmentClassIsMadeUpOfQuery query)
        {
            return await Mediator.Send(query);
        }
        /// <summary>
        /// 新增设备类型
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<BaseResult> Add(AddEquipmentClassCommand command)
        {
            return await Mediator.Send(command);
        }
        /// <summary>
        /// 修改设备类型
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<BaseResult> Update(UpdateEquipmentClassCommand command)
        {
            return await Mediator.Send(command);
        }
        /// <summary>
        /// 删除设备类型
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<BaseResult> Delete(DeleteEquipmentClassCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
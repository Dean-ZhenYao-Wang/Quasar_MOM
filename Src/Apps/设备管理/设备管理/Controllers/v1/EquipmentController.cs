using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOM.Application.Features.PhysicalAssetAndEquipment.Commands.AddEquipment;
using MOM.Application.Features.PhysicalAssetAndEquipment.Commands.AddEquipmentClass;
using MOM.Application.Features.PhysicalAssetAndEquipment.Commands.DeleteEquipment;
using MOM.Application.Features.PhysicalAssetAndEquipment.Commands.DeleteEquipmentClass;
using MOM.Application.Features.PhysicalAssetAndEquipment.Commands.UpdateEquipment;
using MOM.Application.Features.PhysicalAssetAndEquipment.Commands.UpdateEquipmentClass;
using MOM.Application.Features.PhysicalAssetAndEquipment.Queries.GetIncludesRelations;
using MOM.Application.Features.PhysicalAssetAndEquipment.Queries.GetIsMadeUpOf;
using MOM.Application.Features.PhysicalAssetAndEquipment.Queries.GetPagedEquipment;
using MOM.Application.Features.PhysicalAssetAndEquipment.Queries.GetPagedEquipmentClass;
using MOM.Application.Infrastructure;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment;

namespace 设备管理.Controllers.v1
{
    [Tags("设备管理")]
    [ApiVersion("1")]
    public sealed class EquipmentController : BaseApiController
    {
        /// <summary>
        /// 查询设备列表
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<PagedResponse<Equipment>> GetPaged([FromQuery] GetPagedEquipmentQuery query)
        {
            return await Mediator.Send(query);
        }
        /// <summary>
        /// 新增设备
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<BaseResult> Add(AddEquipmentCommand command)
        {
            return await Mediator.Send(command);
        }
        /// <summary>
        /// 修改设备
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<BaseResult> Update(UpdateEquipmentCommand command)
        {
            return await Mediator.Send(command);
        }
        /// <summary>
        /// 删除设备
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<BaseResult> Delete(DeleteEquipmentCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
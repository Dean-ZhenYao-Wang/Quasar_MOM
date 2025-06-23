using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOM.Application.Features.PhysicalAssetAndEquipment.Queries.GetPagedEquipmentClass;
using MOM.Application.Infrastructure;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment;

namespace 设备管理.Controllers.v1
{
    /// <summary>
    /// 编码规则管理器
    /// 负责编码规则的注册、管理和编码生成的核心类
    /// 提供线程安全的编码生成服务，管理序列号状态
    /// </summary>
    [Tags("编码规则管理")]
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
    }
}
using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOM.Application.Features.Material.Commands.AddMaterialClass;
using MOM.Application.Features.Material.Commands.DeleteMaterialClass;
using MOM.Application.Features.Material.Commands.UpdateMaterialClass;
using MOM.Application.Features.Material.Queries.GetPagedMaterialClass;
using MOM.Application.Infrastructure;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.Material;
using MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment;

namespace 物料管理.Controllers.v1
{
    [Tags("物料类管理")]
    [ApiVersion("1")]
    public sealed class MaterialClassController : BaseApiController
    {
        /// <summary>
        /// 查询物料类型列表
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<PagedResponse<MaterialClass>> GetPaged([FromQuery] GetPagedMaterialClassQuery query)
        {
            return await Mediator.Send(query);
        }
        /// <summary>
        /// 新增物料类型
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<BaseResult> Add(AddMaterialClassCommannd command)
        {
            return await Mediator.Send(command);
        }
        /// <summary>
        /// 修改物料类型
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<BaseResult> Update(UpdateMaterialClassCommand command)
        {
            return await Mediator.Send(command);
        }
        /// <summary>
        /// 删除物料类型
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<BaseResult> Delete(DeleteMaterialClassCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}

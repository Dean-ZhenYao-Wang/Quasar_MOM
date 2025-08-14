using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOM.Application.Features.Material.Commands.AddMaterialDefinition;
using MOM.Application.Features.Material.Commands.DeleteMaterialDefinition;
using MOM.Application.Features.Material.Commands.UpdateMaterialDefinition;
using MOM.Application.Features.Material.Queries.GetPagedMaterialDefinition;
using MOM.Application.Infrastructure;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.Material;
using MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment;

namespace 物料管理.Controllers.v1
{
    [Tags("物料定义管理")]
    [ApiVersion("1")]
    public sealed class MaterialDefinitionController : BaseApiController
    {
        /// <summary>
        /// 查询物料定义列表
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<PagedResponse<MaterialDefinition>> GetPaged([FromQuery] GetPagedMaterialDefinitionQuery query)
        {
            return await Mediator.Send(query);
        }
        /// <summary>
        /// 新增物料定义
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<BaseResult> Add(AddMaterialDefinitionCommannd command)
        {
            return await Mediator.Send(command);
        }
        /// <summary>
        /// 修改物料定义
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<BaseResult> Update(UpdateMaterialDefinitionCommand command)
        {
            return await Mediator.Send(command);
        }
        /// <summary>
        /// 删除物料定义
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<BaseResult> Delete(DeleteMaterialDefinitionCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}

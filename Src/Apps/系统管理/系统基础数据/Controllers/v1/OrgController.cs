using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using MOM.Application.DTOs.Common;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Features.HierarchyScope.Commands.AddOrg;
using MOM.Application.Features.HierarchyScope.Commands.DeleteOrg;
using MOM.Application.Features.HierarchyScope.Commands.UpdateOrg;
using MOM.Application.Features.HierarchyScope.Queries.GetOrgTable;
using MOM.Application.Features.HierarchyScope.Queries.GetOrgTree;
using MOM.Application.Infrastructure;
using MOM.Application.Wrappers;

namespace 系统基础数据.Controllers.v1
{
    /// <summary>
    /// 组织管理
    /// </summary>
    [ApiVersion("1")]
    public sealed class OrgController : BaseApiController
    {
        /// <summary>
        /// 查询组织列表
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<PagedResponse<OrgResponse>> GetOrgTable([FromQuery] GetOrgTableQuery query)
        {
            return await Mediator.Send(query);
        }

        /// <summary>
        /// 添加组织
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<BaseResult> AddOrg(AddOrgCommand command)
        {
            var model = await Mediator.Send(command);
            return model;
        }

        /// <summary>
        /// 删除组织
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<BaseResult> DeleteOrg(DeleteOrgCommand command)
        {
            var model = await Mediator.Send(command);
            return model;
        }

        /// <summary>
        /// 修改组织
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<BaseResult> UpdateOrg(UpdateOrgCommand command)
        {
            var model = await Mediator.Send(command);
            return model;
        }

        [HttpGet]
        public async Task<BaseResult<List<TreeNode<OrgResponse>>>> GetDepartTree([FromQuery] Guid? sourceDtId)
        {
            return await Mediator.Send(new GetOrgTreeQuery { SourceDtId = sourceDtId });
        }
    }
}
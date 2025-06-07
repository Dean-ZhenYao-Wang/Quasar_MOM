using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOM.Application.DTOs.Common;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Features.HierarchyScope.Commands.AddHierarchyScope;
using MOM.Application.Features.HierarchyScope.Commands.DeleteHierarchyScope;
using MOM.Application.Features.HierarchyScope.Commands.UpdateHierarchyScope;
using MOM.Application.Features.HierarchyScope.Queries.GetEnterpriseTable;
using MOM.Application.Features.HierarchyScope.Queries.GetFactoryTable;
using MOM.Application.Features.HierarchyScope.Queries.GetOrgTable;
using MOM.Application.Features.HierarchyScope.Queries.GetOrgTree;
using MOM.Application.Features.Permission.Commands.OrgSettingPermission;
using MOM.Application.Features.Permission.Queries.GetOrgPermissionLis;
using MOM.Application.Infrastructure;
using MOM.Application.Wrappers;

namespace 系统基础数据.Controllers.v1
{
    [Tags("设备角色层次/生产建模")]
    [ApiVersion("1")]
    public sealed class HierarchyScopeController : BaseApiController
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
        /// 查询企业列表
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<PagedResponse<OrgResponse>> GetEnterpriseTable([FromQuery] GetEnterpriseTableQuery query)
        {
            return await Mediator.Send(query);
        }
        /// <summary>
        /// 查询工厂列表
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<PagedResponse<OrgResponse>> GetFactoryTable([FromQuery] GetFactoryTableQuery query)
        {
            return await Mediator.Send(query);
        }

        /// <summary>
        /// 添加组织
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<BaseResult> AddHierarchyScope(AddHierarchyScopeCommand command)
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
        public async Task<BaseResult> DeleteHierarchyScope(DeleteHierarchyScopeCommand command)
        {
            var model = await Mediator.Send(command);
            return model;
        }

        /// <summary>
        /// 修改组织
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<BaseResult> UpdateHierarchyScope(UpdateHierarchyScopeCommand command)
        {
            var model = await Mediator.Send(command);
            return model;
        }

        /// <summary>
        /// 获取组织树形
        /// </summary>
        /// <param name="sourceDtId">上级节点的DtId</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<BaseResult<List<TreeNode<OrgResponse>>>> GetDepartTree([FromQuery] Guid? sourceDtId)
        {
            return await Mediator.Send(new GetOrgTreeQuery { SourceDtId = sourceDtId });
        }

        /// <summary>
        /// 给组织结构配置基本权限
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<BaseResult> SettingPermission(OrgSettingPermissionCommand command)
        {
            return await Mediator.Send(command);
        }

        /// <summary>
        /// 获取指定组织的权限列表
        /// </summary>
        /// <param name="orgDtId">指定组织的dtId</param>
        /// <returns>该组织所拥有权限的菜单或按钮的编号</returns>
        [HttpGet]
        public async Task<BaseResult<List<string>>> Permission([FromQuery] Guid orgDtId)
        {
            return await Mediator.Send(new GetOrgPermissionListQuery { OrgDtId = orgDtId });
        }
    }
}
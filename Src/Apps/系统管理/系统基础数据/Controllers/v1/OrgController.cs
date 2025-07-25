using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOM.Application.DTOs.HierarchyScope.Responses;
using MOM.Application.Features.HierarchyScope.Commands.AddEnterpriseOrDepartment;
using MOM.Application.Features.HierarchyScope.Commands.AddFactory;
using MOM.Application.Features.HierarchyScope.Commands.AddProductionLine;
using MOM.Application.Features.HierarchyScope.Commands.AddProductionUnit;
using MOM.Application.Features.HierarchyScope.Commands.AddWorkshop;
using MOM.Application.Features.HierarchyScope.Commands.DeleteHierarchyScope;
using MOM.Application.Features.HierarchyScope.Commands.UpdateEnterpriseOrDepartment;
using MOM.Application.Features.HierarchyScope.Commands.UpdateFactory;
using MOM.Application.Features.HierarchyScope.Commands.UpdateProductionLine;
using MOM.Application.Features.HierarchyScope.Commands.UpdateProductionUnit;
using MOM.Application.Features.HierarchyScope.Commands.UpdateWorkshop;
using MOM.Application.Features.HierarchyScope.Queries.GetDepartmentTable;
using MOM.Application.Features.HierarchyScope.Queries.GetEnterpriseTable;
using MOM.Application.Features.HierarchyScope.Queries.GetFactoryTable;
using MOM.Application.Features.HierarchyScope.Queries.GetProductionLineTable;
using MOM.Application.Features.HierarchyScope.Queries.GetWorkshopTable;
using MOM.Application.Infrastructure;
using MOM.Application.Infrastructure.Attribute;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.EquipmentHierarchy;

namespace 系统基础数据.Controllers.v1
{
    /// <summary>
    /// 基础资料/组织管理
    /// </summary>
    [Tags("基础资料/组织管理")]
    [ApiVersion("1")]
    public sealed class OrgController : BaseApiController
    {
        /// <summary>
        /// 添加企业/部门
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        [Transactional]
        public async Task<BaseResult> AddEnterpriseOrDepartment(AddEnterpriseOrDepartmentCommand command)
        {
            var model = await Mediator.Send(command);
            return model;
        }

        /// <summary>
        /// 修改企业/部门
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut]
        [Transactional]
        public async Task<BaseResult> UpdateEnterpriseOrDepartment(UpdateEnterpriseOrDepartmentCommand command)
        {
            var model = await Mediator.Send(command);
            return model;
        }

        /// <summary>
        /// 删除组织
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpDelete]
        [Transactional]
        public async Task<BaseResult> DeleteHierarchyScope(DeleteHierarchyScopeCommand command)
        {
            var model = await Mediator.Send(command);
            return model;
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
        /// 查询部门列表
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<PagedResponse<OrgResponse>> GetDepartmentTable([FromQuery] GetDepartmentTableQuery query)
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
        /// 添加工厂
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        [Transactional]
        public async Task<BaseResult> AddFactory(AddFactoryCommand command)
        {
            var model = await Mediator.Send(command);
            return model;
        }

        /// <summary>
        /// 修改工厂
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut]
        [Transactional]
        public async Task<BaseResult> UpdateFactory(UpdateFactoryCommand command)
        {
            var model = await Mediator.Send(command);
            return model;
        }
        /// <summary>
        /// 查询区域/车间列表
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<PagedResponse<OrgResponse>> GetAreaTable([FromQuery] GetAreaTableQuery query)
        {
            return await Mediator.Send(query);
        }

        /// <summary>
        /// 添加区域/车间
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        [Transactional]
        public async Task<BaseResult> AddArea(AddAreapCommand command)
        {
            var model = await Mediator.Send(command);
            return model;
        }

        /// <summary>
        /// 修改区域/车间
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut]
        [Transactional]
        public async Task<BaseResult> UpdateArea(UpdateAreaCommand command)
        {
            var model = await Mediator.Send(command);
            return model;
        }
        /// <summary>
        /// 查询产线列表
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<PagedResponse<OrgResponse>> GetProductionLineTable([FromQuery] GetProductionLineTableQuery query)
        {
            return await Mediator.Send(query);
        }

        /// <summary>
        /// 添加产线
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        [Transactional]
        public async Task<BaseResult> AddProductionLine(AddProductionLineCommand command)
        {
            var model = await Mediator.Send(command);
            return model;
        }

        /// <summary>
        /// 修改产线
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut]
        [Transactional]
        public async Task<BaseResult> UpdateProductionLine(UpdateProductionLineCommand command)
        {
            var model = await Mediator.Send(command);
            return model;
        }
        /// <summary>
        /// 查询工段/工位列表
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<PagedResponse<OrgResponse>> GetProductionUnitTable([FromQuery] GetProductionUnitTableQuery query)
        {
            return await Mediator.Send(query);
        }

        /// <summary>
        /// 添加工段/工位
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        [Transactional]
        public async Task<BaseResult> AddProductionUnit(AddProductionUnitCommand command)
        {
            var model = await Mediator.Send(command);
            return model;
        }

        /// <summary>
        /// 修改工段/工位
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut]
        [Transactional]
        public async Task<BaseResult> UpdateProductionUnit(UpdateProductionUnitCommand command)
        {
            var model = await Mediator.Send(command);
            return model;
        }
    }
}
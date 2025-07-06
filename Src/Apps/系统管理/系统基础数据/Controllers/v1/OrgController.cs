using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOM.Application.Features.HierarchyScope.Commands.AddHierarchyScope;
using MOM.Application.Infrastructure;
using MOM.Application.Wrappers;

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
    }
}
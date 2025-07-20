using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOM.Application.Features.Permission.Commands.OrgSettingPermission;
using MOM.Application.Features.Permission.Commands.PersonnelClassSettingPermission;
using MOM.Application.Features.Permission.Commands.PersonnelSettingPermission;
using MOM.Application.Infrastructure;
using MOM.Application.Infrastructure.Attribute;
using MOM.Application.Wrappers;

namespace 系统基础数据.Controllers.v1
{
    /// <summary>
    /// 系统管理/权限配置
    /// </summary>
    [Tags("系统管理/权限配置")]
    [ApiVersion("1")]
    public sealed class PermissionController : BaseApiController
    {
        /// <summary>
        /// 给人配置基本特殊指定权限
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Person")]
        [Transactional]
        public async Task<BaseResult> SettingPermission(PersonnelSettingPermissionCommand command)
        {
            return await Mediator.Send(command);
        }
        /// <summary>
        /// 给组织结构配置基本权限
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Org")]
        [Transactional]
        public async Task<BaseResult> SettingPermission(OrgSettingPermissionCommand command)
        {
            return await Mediator.Send(command);
        }

        /// <summary>
        /// 给职位/班组配置基本权限
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("PersonnelClass")]
        [Transactional]
        public async Task<BaseResult> SettingPermission(PersonnelClassSettingPermissionCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
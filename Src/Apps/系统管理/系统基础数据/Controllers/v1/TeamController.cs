using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOM.Application.DTOs.PersonnelClass.Responses;
using MOM.Application.Features.Permission.Commands.PersonnelClassSettingPermission;
using MOM.Application.Features.PersonnelClass.Commands.AddTeam;
using MOM.Application.Features.PersonnelClass.Commands.DeletePersonnelClass;
using MOM.Application.Features.PersonnelClass.Commands.UpdateTeam;
using MOM.Application.Features.PersonnelClass.Queries.GetPagedTeam;
using MOM.Application.Features.PersonnelClass.Queries.GetTeamSelectOptions;
using MOM.Application.Infrastructure;
using MOM.Application.Infrastructure.Attribute;
using MOM.Application.Wrappers;

namespace 系统基础数据.Controllers.v1
{
    /// <summary>
    /// 班组管理
    /// </summary>
    [Tags("班组管理")]
    [ApiVersion("1")]
    public sealed class TeamController : BaseApiController
    {
        /// <summary>
        /// 查询班组下拉列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<BaseResult<List<PersonnelClassResponse>>> SelectOptions()
        {
            return await Mediator.Send(new GetTeamSelectOptionsQuery());
        }

        /// <summary>
        /// 查询班组列表
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<PagedResponse<TeamResponse>> GetPaged([FromQuery] GetPagedTeamQuery query)
        {
            return await Mediator.Send(query);
        }

        /// <summary>
        /// 新增班组
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        [Transactional]
        public async Task<BaseResult> Add(AddTeamCommand command)
        {
            return await Mediator.Send(command);
        }

        /// <summary>
        /// 修改班组
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        [Transactional]
        public async Task<BaseResult> Update(UpdateTeamCommand command)
        {
            return await Mediator.Send(command);
        }

        /// <summary>
        /// 删除班组
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpDelete]
        [Transactional]
        public async Task<BaseResult> Delete(DeletePersonnelClassCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
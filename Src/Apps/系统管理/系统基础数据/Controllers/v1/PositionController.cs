using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOM.Application.DTOs.PersonnelClass.Responses;
using MOM.Application.Features.Permission.Commands.PersonnelClassSettingPermission;
using MOM.Application.Features.PersonnelClass.Commands.AddPsitoion;
using MOM.Application.Features.PersonnelClass.Commands.DeletePosition;
using MOM.Application.Features.PersonnelClass.Commands.UpdatePosition;
using MOM.Application.Features.PersonnelClass.Queries.GetPagedPosition;
using MOM.Application.Features.PersonnelClass.Queries.GetPositionSelectOptions;
using MOM.Application.Infrastructure;
using MOM.Application.Wrappers;

namespace 系统基础数据.Controllers.v1
{
    /// <summary>
    /// 职位管理
    /// </summary>
    [Tags("职位管理")]
    [ApiVersion("1")]
    public sealed class PositionController : BaseApiController
    {
        /// <summary>
        /// 查询职位下拉列表
        /// </summary>
        /// <returns></returns>
        [HttpGet(nameof(SelectOptions))]
        public async Task<BaseResult<List<PersonnelClassResponse>>> SelectOptions()
        {
            return await Mediator.Send(new GetPositionSelectOptionsQuery());
        }

        /// <summary>
        /// 查询职位列表
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet(nameof(GetPaged))]
        public async Task<PagedResponse<PersonnelClassResponse>> GetPaged([FromQuery] GetPagedPositionQuery query)
        {
            return await Mediator.Send(query);
        }

        /// <summary>
        /// 新增职位
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost(nameof(Add))]
        public async Task<BaseResult> Add(AddPositionCommand command)
        {
            return await Mediator.Send(command);
        }

        /// <summary>
        /// 修改职位
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost(nameof(Update))]
        public async Task<BaseResult> Update(UpdatePositionCommand command)
        {
            return await Mediator.Send(command);
        }

        /// <summary>
        /// 删除职位
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpDelete(nameof(Delete))]
        public async Task<BaseResult> Delete(DeletePersonnelClassCommand command)
        {
            return await Mediator.Send(command);
        }

        /// <summary>
        /// 给职位配置基本权限
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost(nameof(SettingPermission))]
        public async Task<BaseResult> SettingPermission(PersonnelClassSettingPermissionCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOM.Application.DTOs.Menu.Responses;
using MOM.Application.Features.Permission.Commands.AddButton;
using MOM.Application.Features.Permission.Commands.AddMenu;
using MOM.Application.Features.Permission.Commands.DeleteButton;
using MOM.Application.Features.Permission.Commands.DeleteMenu;
using MOM.Application.Features.Permission.Commands.UpdateButton;
using MOM.Application.Features.Permission.Commands.UpdateMenu;
using MOM.Application.Features.Permission.Queries.GetButtonList;
using MOM.Application.Features.Permission.Queries.GetMenuList;
using MOM.Application.Features.Permission.Queries.GetMenuTree;
using MOM.Application.Infrastructure;
using MOM.Application.Wrappers;

namespace 系统基础数据.Controllers.v1
{
    /// <summary>
    /// 菜单管理
    /// </summary>
    [Tags("菜单管理")]
    [ApiVersion("1")]
    public sealed class MenuController : BaseApiController
    {
        /// <summary>
        /// 菜单管理页面获得所有菜单树
        /// </summary>
        /// <returns></returns>
        [HttpGet(nameof(GetMenuTree))]
        public async Task<BaseResult<List<MenuTreeNodeResponse>>> GetMenuTree()
        {
            return await Mediator.Send(new GetMenuTreeQuery());
        }

        [HttpPost(nameof(AddMenu))]
        public async Task<BaseResult> AddMenu(AddMenuCommand command)
        {
            var model = await Mediator.Send(command);
            return model;
        }

        [HttpPost(nameof(AddButton))]
        public async Task<BaseResult> AddButton(AddButtonCommand command)
        {
            var model = await Mediator.Send(command);
            return model;
        }

        [HttpPut(nameof(UpdateMenu))]
        public async Task<BaseResult> UpdateMenu(UpdateMenuCommand command)
        {
            var model = await Mediator.Send(command);
            return model;
        }

        [HttpPut(nameof(UpdateButton))]
        public async Task<BaseResult> UpdateButton(UpdateButtonCommand command)
        {
            var model = await Mediator.Send(command);
            return model;
        }

        [HttpDelete(nameof(DeleteMenu))]
        public async Task<BaseResult> DeleteMenu(DeleteMenuCommand command)
        {
            var model = await Mediator.Send(command);
            return model;
        }

        [HttpDelete(nameof(DeleteButton))]
        public async Task<BaseResult> DeleteButton(DeleteButtonCommand command)
        {
            var model = await Mediator.Send(command);
            return model;
        }

        [HttpGet(nameof(GetMenuList))]
        public async Task<BaseResult<List<MenuResponse>>> GetMenuList([FromQuery] GetMenuListQuery command)
        {
            var model = await Mediator.Send(command);
            return model;
        }

        [HttpGet]
        [Route("{menuDtId}")]
        public async Task<BaseResult<List<ButtonResponse>>> GetButtonList(Guid menuDtId)
        {
            var model = await Mediator.Send(new GetButtonListQuery() { ParentMenuDtId = menuDtId });
            return model;
        }

        [HttpGet]
        [Route("{menuId}")]
        public async Task<BaseResult<List<ButtonResponse>>> ButtonList(string menuId)
        {
            var model = await Mediator.Send(new GetButtonListQuery() { ParentMenuId = menuId });
            return model;
        }
    }
}
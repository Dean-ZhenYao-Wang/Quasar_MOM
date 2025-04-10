using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
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
using MOM.Application.Infrastructure.Services;
using MOM.Application.Interfaces;
using MOM.Application.Wrappers;
using MOM.Domain.Permission;
using Newtonsoft.Json;

namespace 系统基础数据.Controllers
{
    [ApiVersion("1")]
    public sealed class MenuController(IUnitOfWork unitOfWork, IAuthenticatedUserService authenticatedUser, ITranslator translator) : BaseApiController
    {
        /// <summary>
        /// 菜单管理页面获得所有菜单树
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize(Roles = "管理员,超级管理员")]
        public async Task<BaseResult<List<MenuTreeNodeResponse>>> GetMenuTree()
        {
            return await Mediator.Send(new GetMenuTreeQuery());
        }
        [HttpPost]
        public async Task<BaseResult> AddMenu(AddMenuCommand command)
        {
            var model = await Mediator.Send(command);
            if (model.Success)
            {
                await unitOfWork.SaveChangesAsync();
            }
            return model;
        }
        [HttpPost]
        public async Task<BaseResult> AddButton(AddButtonCommand command)
        {
            var model = await Mediator.Send(command);
            if (model.Success)
            {
                await unitOfWork.SaveChangesAsync();
            }
            return model;
        }
        [HttpPut]
        public async Task<BaseResult> UpdateMenu(UpdateMenuCommand command)
        {
            var model = await Mediator.Send(command);
            if (model.Success)
            {
                await unitOfWork.SaveChangesAsync();
            }
            return model;
        }
        [HttpPut]
        public async Task<BaseResult> UpdateButton(UpdateButtonCommand command)
        {
            var model = await Mediator.Send(command);
            if (model.Success)
            {
                await unitOfWork.SaveChangesAsync();
            }
            return model;
        }
        [HttpDelete]
        public async Task<BaseResult> DeleteMenu(DeleteMenuCommand command)
        {
            var model = await Mediator.Send(command);
            if (model.Success)
            {
                await unitOfWork.SaveChangesAsync();
            }
            return model;
        }
        [HttpDelete]
        public async Task<BaseResult> DeleteButton(DeleteButtonCommand command)
        {
            var model = await Mediator.Send(command);
            if (model.Success)
            {
                await unitOfWork.SaveChangesAsync();
            }
            return model;
        }
        [HttpGet]
        public async Task<BaseResult<List<MenuResponse>>> GetMenuList([FromQuery] GetMenuListQuery command)
        {
            var model = await Mediator.Send(command);
            return model;
        }
        [HttpGet]
        public async Task<BaseResult<List<ButtonResponse>>> GetButtonList([FromQuery]Guid menuDtId)
        {
            var model = await Mediator.Send(new GetButtonListQuery() { ParentMenuDtId = menuDtId });
            return model;
        }
    }
}

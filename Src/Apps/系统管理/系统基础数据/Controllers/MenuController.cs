using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MOM.Application.DTOs.Account.Responses;
using MOM.Application.DTOs.Menu.Responses;
using MOM.Application.Infrastructure;
using MOM.Application.Infrastructure.Services;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using MOM.ApplicationFeatures.Permission.Commands.AddMenu;
using MOM.ApplicationFeatures.Permission.Commands.DeleteMenu;
using MOM.ApplicationFeatures.Permission.Commands.UpdateMenu;
using MOM.ApplicationFeatures.Permission.Queries;
using MOM.ApplicationFeatures.Permission.Queries.GetMenuList;
using MOM.ApplicationFeatures.Permission.Queries.GetMenuTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        [Authorize(Policy = "管理员,超级管理员")]
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
        [HttpGet]
        public async Task<BaseResult<List<MenuResponse>>> GetMenuList(GetMenuListQuery command)
        {
            var model = await Mediator.Send(command);
            if (model.Success)
            {
                await unitOfWork.SaveChangesAsync();
            }
            return model;
        }
    }
}

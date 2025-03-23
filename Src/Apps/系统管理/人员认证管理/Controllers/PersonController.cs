using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.HttpSys;
using MOM.Application.Features.Personnel.Commands.AddPerson;
using MOM.Application.Infrastructure;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.UserInterfaces;
using MOM.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 人员认证管理.Controllers
{
    /// <summary>
    /// 人员管理
    /// </summary>
    [ApiVersion("1")]
    public sealed class PersonController(IAccountServices accountServices) : BaseApiController
    {
        /// <summary>
        /// 添加人员/创建账号
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<BaseResult> AddPerson(AddPersonCommand request)//属性尤其是从人员类继承的属性（mapsTo）
        {
            Guid userId = Guid.NewGuid();
            var addCountResult = await accountServices.AddAccountAsync(userId, request.Id, request.Name, request.Email, request.PhoneNumber, request.PositionDtId_List);
            if (addCountResult.Success)
            {
                request.DtId = userId;
                return await Mediator.Send(request);
            }
            else
            {
                return addCountResult;
            }
        }
    }
}

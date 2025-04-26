using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using MOM.Application.DTOs.Department.Responses;
using MOM.Application.Features.PersonnelClass.Commands.AddDepartment;
using MOM.Application.Features.PersonnelClass.Commands.DeleteDepartment;
using MOM.Application.Features.PersonnelClass.Commands.UpdateDepartment;
using MOM.Application.Features.PersonnelClass.Queries.GetDepartmentTree;
using MOM.Application.Infrastructure;
using MOM.Application.Interfaces;
using MOM.Application.Wrappers;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace 系统基础数据.Controllers.v1
{
    [ApiVersion("1")]
    public sealed class DepartmentController : BaseApiController
    {
        /// <summary>
        /// 添加部门
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<BaseResult> AddDepartment(AddDepartmentCommand command)
        {
            var model = await Mediator.Send(command);
            return model;
        }
        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<BaseResult> DeleteDepartment(DeleteDepartmentCommand command)
        {
            var model = await Mediator.Send(command);
            return model;
        }
        /// <summary>
        /// 修改部门
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<BaseResult> UpdateDepartment(UpdateDepartmentCommand command)
        {
            var model = await Mediator.Send(command);
            return model;
        }
        [HttpGet]
        public async Task<BaseResult<List<DepartmentResponse>>> GetDepartTree([FromQuery]Guid? sourceDtId)
        {
            return await Mediator.Send(new GetDepartmentTreeQuery { SourceDtId= sourceDtId });
        }
    }
}

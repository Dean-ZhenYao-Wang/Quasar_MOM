using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOM.Application.DTOs.Personnel.Responses;
using MOM.Application.DTOs.Resource.Responses;
using MOM.Application.Features.Personnel.Commands.AddPerson;
using MOM.Application.Features.Personnel.Commands.DeletePerson;
using MOM.Application.Features.Personnel.Commands.UpdatePerson;
using MOM.Application.Features.Personnel.Queries.GetPagedListPerson;
using MOM.Application.Features.Personnel.Queries.GetProperties;
using MOM.Application.Features.Personnel.Queries.GetResponsibles;
using MOM.Application.Infrastructure;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;

namespace 人员认证管理.Controllers.v1
{
    [Tags("人员管理")]
    [ApiVersion("1")]
    public sealed class PersonController : BaseApiController
    {
        /// <summary>
        /// 获取负责人下拉列表数据，此处默认获取全部人员，可根据客户需求进行定制（增加数据过滤条件）
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<BaseResult<List<Person>>> GetResponsibles()
        {
            return await Mediator.Send(new GetResponsiblesQuery());
        }

        /// <summary>
        /// 获取指定人员的自定义属性清单
        /// </summary>
        /// <param name="dtId">指定人员的DtId</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<BaseResult<List<ResourcePropertyResponse>>> GetProperties(GetPropertiesQuery command)
        {
            return await Mediator.Send(command);
        }

        /// <summary>
        /// 添加人员/创建账号
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<BaseResult> AddPerson(AddPersonCommand request)//属性尤其是从人员类继承的属性（mapsTo）
        {
            var model = await Mediator.Send(request);
            return model;
        }

        /// <summary>
        /// 分页获取人员
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<PagedResponse<PersonResponse>> GetPageListPerson([FromQuery] GetPagedListPersonQuery request)
        {
            return await Mediator.Send(request);
        }

        /// <summary>
        /// 删除人员
        /// </summary>
        /// <param name="dtIds"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<BaseResult> DeletePerson(DeletePersonCommand command)
        {
            var deleteResoult = await Mediator.Send(command);
            return deleteResoult;
        }

        /// <summary>
        /// 修改人员
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<BaseResult> UpdatePerson(UpdatePersonCommand command)//属性尤其是从人员类继承的属性（mapsTo）
        {
            var updateResoult = await Mediator.Send(command);
            return updateResoult;
        }
    }
}
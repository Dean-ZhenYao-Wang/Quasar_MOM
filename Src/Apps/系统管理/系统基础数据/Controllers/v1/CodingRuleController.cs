using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOM.Application.Features.CodingRule.Commands.RegisterRule;
using MOM.Application.Features.CodingRule.Queries.GetPagedCodingRule;
using MOM.Application.Features.PersonnelClass.Queries.GetPagedPosition;
using MOM.Application.Infrastructure;
using MOM.Application.Wrappers;

namespace 系统基础数据.Controllers.v1
{
    /// <summary>
    /// 编码规则管理器
    /// 负责编码规则的注册、管理和编码生成的核心类
    /// 提供线程安全的编码生成服务，管理序列号状态
    /// </summary>
    [Tags("编码规则管理")]
    [ApiVersion("1")]
    public sealed class CodingRuleController : BaseApiController
    {
        /// <summary>
        /// 注册编码规则
        /// 将编码规则添加到管理器中，如果规则ID已存在则会覆盖原规则
        /// </summary>
        [HttpPost]
        public async Task<BaseResult> RegisterRule(RegisterRuleCommand request)
        {
            return await Mediator.Send(request);
        }
        /// <summary>
        /// 查询编码规则列表
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<PagedResponse<MOM.Domain.CodingRule.CodingRule>> GetPaged([FromQuery] GetPagedCodingRuleQuery query)
        {
            return await Mediator.Send(query);
        }
    }
}
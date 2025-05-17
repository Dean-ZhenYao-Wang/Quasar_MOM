using System;
using System.Collections.Generic;
using System.Linq;
using Asp.Versioning;
using Hangfire.Tags.Attributes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOM.Application.Infrastructure;
using MOM.Application.Wrappers;

namespace MOM.WebApi.Controllers.v1
{
    [Tags("系统通用注释内容")]
    [ApiVersion("1", Deprecated = true)]
    public class DocController : BaseApiController
    {
        /// <summary>
        /// 所有错误代码对应解释
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public Dictionary<string, string> GetErrorCodes()
        {
            return Enum.GetValues(typeof(ErrorCode))
                 .Cast<ErrorCode>()
                 .ToDictionary(t => ((int)t).ToString(), t => t.ToString());
        }
    }
}

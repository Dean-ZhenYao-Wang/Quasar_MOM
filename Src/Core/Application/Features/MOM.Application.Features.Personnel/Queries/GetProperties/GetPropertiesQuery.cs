using MediatR;
using MOM.Application.DTOs.Resource.Responses;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.Personnel.Queries.GetProperties
{
    /// <summary>
    ///获取指定人员的自定义属性清单
    /// </summary>
    public class GetPropertiesQuery : IRequest<List<ResourcePropertyResponse>>
    {
        public Guid DtId { get; set; }
    }
}

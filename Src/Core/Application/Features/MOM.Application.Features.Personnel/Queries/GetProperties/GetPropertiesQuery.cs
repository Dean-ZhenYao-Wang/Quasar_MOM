using MediatR;
using MOM.Application.DTOs.Resource.Responses;

namespace MOM.Application.Features.Personnel.Queries.GetProperties
{
    /// <summary>
    ///获取指定人员的自定义属性清单
    /// </summary>
    public class GetPropertiesQuery : IRequest<List<ResourcePropertyResponse>>
    {
        /// <summary>
        /// 指定人员的DtId
        /// </summary>
        public Guid DtId { get; set; }
    }
}
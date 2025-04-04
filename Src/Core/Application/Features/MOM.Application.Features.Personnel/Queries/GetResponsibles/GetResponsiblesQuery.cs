using MediatR;
using MOM.Application.Wrappers;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.Personnel.Queries.GetResponsibles
{
    /// <summary>
    /// 获取负责人下拉列表数据，此处默认获取全部人员，可根据客户需求进行定制（增加数据过滤条件）
    /// </summary>
    public class GetResponsiblesQuery : IRequest<List<Person>> {}
}

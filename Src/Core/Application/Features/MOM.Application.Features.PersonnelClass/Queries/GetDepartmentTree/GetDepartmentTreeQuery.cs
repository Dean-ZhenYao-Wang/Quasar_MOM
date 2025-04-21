using MediatR;
using MOM.Application.DTOs.Department.Responses;
using MOM.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Application.Features.PersonnelClass.Queries.GetDepartmentTree
{
    public class GetDepartmentTreeQuery:IRequest<List<DepartmentResponse>>
    {
        /// <summary>
        /// 上级菜单DtId
        /// </summary>
        public Guid? SourceDtId { get; set; }
    }
    public class GetDepartmentTreeQueryHandler(IPersonnelClassRepository personnelClassRepository) : IRequestHandler<GetDepartmentTreeQuery, List<DepartmentResponse>>
    {
        public async Task<List<DepartmentResponse>> Handle(GetDepartmentTreeQuery request, CancellationToken cancellationToken)
        {
            return await personnelClassRepository.GetDepartmentTreeAsync(request.SourceDtId);
        }
    }
}

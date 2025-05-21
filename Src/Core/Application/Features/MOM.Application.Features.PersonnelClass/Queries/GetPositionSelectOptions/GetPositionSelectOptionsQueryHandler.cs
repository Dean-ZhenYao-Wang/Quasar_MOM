using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.DTOs.PersonnelClass.Responses;
using MOM.Application.Interfaces.Repositories;

namespace MOM.Application.Features.PersonnelClass.Queries.GetPositionSelectOptions
{
    public class GetPositionSelectOptionsQueryHandler(IPersonnelClassRepository personnelClassRepository) : IRequestHandler<GetPositionSelectOptionsQuery, List<PersonnelClassResponse>>
    {
        public async Task<List<PersonnelClassResponse>> Handle(GetPositionSelectOptionsQuery request, CancellationToken cancellationToken)
        {
            return await personnelClassRepository.DbSet
                .Where(x => x.Description.Equals("职位"))
                .Select(x => new PersonnelClassResponse
                {
                    DtId = x.DtId,
                    Id = x.Id,
                }).ToListAsync();
        }
    }
}

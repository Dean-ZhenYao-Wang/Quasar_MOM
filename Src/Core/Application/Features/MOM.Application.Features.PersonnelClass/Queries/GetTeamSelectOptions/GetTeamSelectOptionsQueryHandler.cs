using MediatR;
using Microsoft.EntityFrameworkCore;
using MOM.Application.DTOs.PersonnelClass.Responses;
using MOM.Application.Interfaces.Repositories;

namespace MOM.Application.Features.PersonnelClass.Queries.GetTeamSelectOptions
{
    public class GetTeamSelectOptionsQueryHandler(IPersonnelClassRepository personnelClassRepository) : IRequestHandler<GetTeamSelectOptionsQuery, List<PersonnelClassResponse>>
    {
        public async Task<List<PersonnelClassResponse>> Handle(GetTeamSelectOptionsQuery request, CancellationToken cancellationToken)
        {
            return await personnelClassRepository.DbSet
                .Where(x => x.Description.Equals("班组"))
                .Select(x => new PersonnelClassResponse
                {
                    DtId = x.DtId,
                    Id = x.Id,
                }).ToListAsync();
        }
    }
}
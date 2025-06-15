using MediatR;
using MOM.Application.Interfaces.Repositories;
using MOM.Application.Wrappers;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MOM.Application.Features.CodingRule.Queries.GetPagedCodingRule
{
    public class GetPagedCodingRuleQueryHandler(ICodingRuleRepository codingRuleRepository) : IRequestHandler<GetPagedCodingRuleQuery, PagedResponse<MOM.Domain.CodingRule.CodingRule>>
    {
        public async Task<PagedResponse<Domain.CodingRule.CodingRule>> Handle(GetPagedCodingRuleQuery request, CancellationToken cancellationToken)
        {
            var query = codingRuleRepository
                .Where(m => !string.IsNullOrWhiteSpace(request.Id) ? m.Id.Contains(request.Id) : true)
                .Where(m => !string.IsNullOrWhiteSpace(request.Name) ? m.Name.Contains(request.Name) : true)
                .Where(m => !string.IsNullOrWhiteSpace(request.ModelTypeName) ? m.Name.Equals(request.ModelTypeName) : true)
                .Where(m => request.IsActive.HasValue ? m.IsActive == request.IsActive : true);

            return await codingRuleRepository.PagedAsync(query, request.PageNumber, request.PageSize);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using MOM.Domain.CodingRule;

namespace MOM.Application.Interfaces.Repositories
{
    public interface ICodingRuleRepository : IGenericRepository<CodingRule>
    {
        DbSet<SequenceState> SequenceStates { get; }

        Task<int> GetNextSequenceAsync(Type modelType, string v);

        Task<CodingRule> GetRuleAsync(string id);
    }
}
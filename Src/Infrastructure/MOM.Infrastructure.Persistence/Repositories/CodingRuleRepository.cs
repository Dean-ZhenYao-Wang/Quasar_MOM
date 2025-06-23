using Microsoft.EntityFrameworkCore;
using MOM.Application.Interfaces.Repositories;
using MOM.Domain.CodingRule;
using MOM.Infrastructure.Persistence.Contexts;
using System;
using System.Threading.Tasks;

namespace MOM.Infrastructure.Persistence.Repositories
{
    public class CodingRuleRepository(ApplicationDbContext dbContext) : GenericRepository<CodingRule>(dbContext)
        , ICodingRuleRepository
    {
        public DbSet<SequenceState> SequenceStates => dbContext.SequenceStates;

        /// <summary>
        /// 获取指定模型类型和序列名称的下一个序列号
        /// 每次调用会使序列号自动递增1
        /// </summary>
        /// <param name="modelType">模型类型</param>
        /// <param name="sequenceName">序列名称，用于区分同一模型的不同序列</param>
        /// <returns>下一个序列号</returns>
        public async Task<int> GetNextSequenceAsync(Type modelType, string sequenceName)
        {
            var modelTypeName = modelType.AssemblyQualifiedName;
            var sequence = await SequenceStates
                .FirstOrDefaultAsync(s => s.ModelTypeName == modelTypeName && s.SequenceName == sequenceName);
            //确保模型类型的指定序列名称的序列存在
            if (sequence == null)
            {
                sequence = new SequenceState
                {
                    ModelTypeName = modelTypeName,
                    SequenceName = sequenceName,
                    CurrentValue = 1
                };
                SequenceStates.Add(sequence);
            }
            else
            {
                //递增并返回序列号
                sequence.CurrentValue += 1;
            }

            await SaveChangesAsync();
            return sequence.CurrentValue;
        }

        public async Task<CodingRule> GetRuleAsync(string id)
        {
            return await dbContext.CodingRules
               .Include(r => r.Segments)
               .FirstOrDefaultAsync(r => r.Id.Equals(id));
        }
    }
}
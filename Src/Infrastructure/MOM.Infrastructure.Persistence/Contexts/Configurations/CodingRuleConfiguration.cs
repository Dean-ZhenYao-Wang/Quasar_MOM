using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOM.Domain.CodingRule;

namespace MOM.Infrastructure.Persistence.Contexts.Configurations
{
    public class CodingRuleConfiguration : IEntityTypeConfiguration<CodingRule>
    {
        public void Configure(EntityTypeBuilder<CodingRule> builder)
        {
            builder
                .Ignore(r => r.ModelType); // 非持久化属性
        }
    }
}
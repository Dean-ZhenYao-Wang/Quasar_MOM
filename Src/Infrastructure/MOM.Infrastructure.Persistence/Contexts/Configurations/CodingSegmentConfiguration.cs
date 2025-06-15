using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOM.Domain.CodingRule;

namespace MOM.Infrastructure.Persistence.Contexts.Configurations
{
    public class CodingSegmentConfiguration : IEntityTypeConfiguration<CodingSegment>
    {
        public void Configure(EntityTypeBuilder<CodingSegment> builder)
        {
            builder
                .HasOne(s => s.Rule)
                .WithMany(r => r.Segments)
                .HasForeignKey(s => s.RuleDtId);
        }
    }
}
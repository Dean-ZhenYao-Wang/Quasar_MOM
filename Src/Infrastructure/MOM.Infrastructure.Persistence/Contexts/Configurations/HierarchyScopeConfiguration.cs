using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOM.Domain.isa95.CommonObjectModels;

namespace MOM.Infrastructure.Persistence.Contexts.Configurations
{
    public class HierarchyScopeConfiguration : IEntityTypeConfiguration<HierarchyScope>
    {
        public void Configure(EntityTypeBuilder<HierarchyScope> builder)
        {
            builder.ToTable(nameof(HierarchyScope));
            builder.HasMany(hs => hs.Contains)
                .WithOne(st => st.Source)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(hs => hs.SourceId);
            builder.HasMany(hs => hs.Peoples)
                .WithOne(p => p.HierarchyScopeRel)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(p => p.HierarchyScopeRelDtId);
            builder.HasMany(hs => hs.Teams)
                .WithOne(p => p.HierarchyScopeRel)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(p => p.HierarchyScopeRelDtId);
        }
    }
}
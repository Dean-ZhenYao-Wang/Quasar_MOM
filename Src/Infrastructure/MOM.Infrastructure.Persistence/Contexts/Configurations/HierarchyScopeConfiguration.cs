using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOM.Domain.Common.Relationship.isa95.HierarchyScope;
using MOM.Domain.isa95.CommonObjectModels;
using MOM.Domain.isa95.CommonObjectModels.Part2.OperationalLocation;

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

    public class OperationalLocationConfiguration : IEntityTypeConfiguration<OperationalLocation>
    {
        public void Configure(EntityTypeBuilder<OperationalLocation> builder)
        {
            builder.ToTable(nameof(OperationalLocation));
            builder.HasMany(hs => hs.IsMadeUpOf)
                .WithOne(st => st.Source)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(hs => hs.SourceId);
            
        }
    }
    public class OperationalLocationPropertyConfiguration : IEntityTypeConfiguration<OperationalLocationProperty>
    {
        public void Configure(EntityTypeBuilder<OperationalLocationProperty> builder)
        {
            builder.ToTable(nameof(OperationalLocationProperty));
            builder.HasMany(hs => hs.Contains)
                .WithOne(st => st.Source)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(hs => hs.SourceId);
        }
    }
    public class OperationalLocationClassConfiguration : IEntityTypeConfiguration<OperationalLocationClass>
    {
        public void Configure(EntityTypeBuilder<OperationalLocationClass> builder)
        {
            builder.ToTable(nameof(OperationalLocationClass));
            builder.HasMany(hs => hs.IncludesPropertiesOf)
                .WithOne(st => st.Source)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(hs => hs.SourceId);
            builder.HasMany(hs => hs.IsMadeUpOf)
                .WithOne(st => st.Source)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(hs => hs.SourceId);
        }
    }
    public class OperationalLocationClassPropertyConfiguration : IEntityTypeConfiguration<OperationalLocationClassProperty>
    {
        public void Configure(EntityTypeBuilder<OperationalLocationClassProperty> builder)
        {
            builder.ToTable(nameof(OperationalLocationClassProperty));
            builder.HasMany(hs => hs.Contains)
                .WithOne(st => st.Source)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(hs => hs.SourceId);
        }
    }
}
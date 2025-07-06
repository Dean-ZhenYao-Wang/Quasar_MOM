using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOM.Domain.Common.Relationship.isa95.HierarchyScope;
using MOM.Domain.isa95.CommonObjectModels;
using MOM.Domain.isa95.EquipmentHierarchy;
using System.Reflection.Emit;

namespace MOM.Infrastructure.Persistence.Contexts.Configurations
{
    public class HierarchyScopeConfiguration : IEntityTypeConfiguration<HierarchyScope>
    {
        public void Configure(EntityTypeBuilder<HierarchyScope> builder)
        {
            builder.UseTptMappingStrategy();

            builder.ToTable(nameof(HierarchyScope))
                .HasDiscriminator<string>("Discriminator")
                .HasValue<Area>("Area")
                .HasValue<Enterprise>("Enterprise")
                .HasValue<ProcessCell>("ProcessCell")
                .HasValue<ProductionLine>("ProductionLine")
                .HasValue<ProductionUnit>("ProductionUnit")
                .HasValue<ProductionUnit>("ProductionUnit")
                .HasValue<Site>("Site")
                .HasValue<StorageUnit>("StorageUnit")
                .HasValue<StorageZone>("StorageZone")
                .HasValue<Unit>("Unit")
                .HasValue<WorkCell>("WorkCell")
                .HasValue<WorkCenter>("WorkCenter")
                .HasValue<WorkUnit>("WorkUnit")
            ;

            builder.HasOne(h => h.Source)
                .WithMany()
                .HasForeignKey(h => h.SourceDtId)
                .OnDelete(DeleteBehavior.Restrict);

            //builder.HasMany(hs => hs.Contains)
            //    .WithOne(st => st.Source)
            //    .OnDelete(DeleteBehavior.NoAction)
            //    .HasForeignKey(hs => hs.SourceId);

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
    public class HierarchyScopeContainsRelationshipConfiguration : IEntityTypeConfiguration<HierarchyScopeContainsRelationship>
    {
        public void Configure(EntityTypeBuilder<HierarchyScopeContainsRelationship> builder)
        {
            builder.ToTable(nameof(HierarchyScopeContainsRelationship));

            builder
                .HasOne(r => r.Source)
                .WithMany(h => h.Contains)
                .HasForeignKey(r => r.SourceId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(r => r.Target)
                .WithMany()
                .HasForeignKey(r => r.TargetId)
                .OnDelete(DeleteBehavior.Restrict);

            // 确保Parent-Child关系的一致性约束
            builder
                .HasIndex(r => new { r.SourceId, r.TargetId })
                .IsUnique();

        }
    }
}
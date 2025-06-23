using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOM.Domain.Common.Relationship.isa95.EquipmentClass;
using MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment;
using System.Reflection.Emit;

namespace MOM.Infrastructure.Persistence.Contexts.Configurations
{
    public class EquipmentClassConfiguration : IEntityTypeConfiguration<EquipmentClass>
    {
        public void Configure(EntityTypeBuilder<EquipmentClass> builder)
        {
            builder.ToTable(nameof(EquipmentClass));
            builder.HasMany(ec => ec.IncludesPropertiesOf)
                .WithOne(st => st.Source)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(ec => ec.SourceId);

            builder.HasMany(hs => hs.IsMadeUpOf)
                .WithOne(st => st.Source)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(hs => hs.SourceId);
        }
    }
}
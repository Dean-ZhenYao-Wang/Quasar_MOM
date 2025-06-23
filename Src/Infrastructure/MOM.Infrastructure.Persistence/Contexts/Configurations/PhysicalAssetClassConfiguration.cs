using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment;

namespace MOM.Infrastructure.Persistence.Contexts.Configurations
{
    public class PhysicalAssetClassConfiguration : IEntityTypeConfiguration<PhysicalAssetClass>
    {
        public void Configure(EntityTypeBuilder<PhysicalAssetClass> builder)
        {
            builder.ToTable(nameof(PhysicalAssetClass));

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
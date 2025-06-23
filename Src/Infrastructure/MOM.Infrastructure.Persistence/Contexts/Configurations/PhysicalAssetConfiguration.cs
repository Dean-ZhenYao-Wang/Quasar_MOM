using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment;

namespace MOM.Infrastructure.Persistence.Contexts.Configurations
{
    public class PhysicalAssetConfiguration : IEntityTypeConfiguration<PhysicalAsset>
    {
        public void Configure(EntityTypeBuilder<PhysicalAsset> builder)
        {
            builder.ToTable(nameof(PhysicalAsset));

            builder.HasMany(hs => hs.IsMadeUpOf)
                .WithOne(st => st.Source)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(hs => hs.SourceId);
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOM.Domain.isa95.EquipmentHierarchy;

namespace MOM.Infrastructure.Persistence.Contexts.Configurations
{
    public class StorageZoneConfiguration : IEntityTypeConfiguration<StorageZone>
    {
        public void Configure(EntityTypeBuilder<StorageZone> builder)
        {
            builder.ToTable(nameof(StorageZone));
        }
    }
}
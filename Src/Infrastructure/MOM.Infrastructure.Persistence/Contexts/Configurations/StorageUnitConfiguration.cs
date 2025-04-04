using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOM.Domain.isa95.EquipmentHierarchy;

namespace MOM.Infrastructure.Persistence.Contexts.Configurations
{
    public class StorageUnitConfiguration : IEntityTypeConfiguration<StorageUnit>
    {
        public void Configure(EntityTypeBuilder<StorageUnit> builder)
        {
            builder.ToTable(nameof(StorageUnit));
        }
    }
}
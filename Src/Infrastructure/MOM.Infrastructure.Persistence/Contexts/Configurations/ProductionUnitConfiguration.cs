using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOM.Domain.isa95.EquipmentHierarchy;

namespace MOM.Infrastructure.Persistence.Contexts.Configurations
{
    public class ProductionUnitConfiguration : IEntityTypeConfiguration<ProductionUnit>
    {
        public void Configure(EntityTypeBuilder<ProductionUnit> builder)
        {
            builder.ToTable(nameof(ProductionUnit));
        }
    }
}
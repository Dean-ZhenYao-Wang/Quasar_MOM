using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOM.Domain.isa95.EquipmentHierarchy;

namespace MOM.Infrastructure.Persistence.Contexts.Configurations
{
    public class ProductionLineConfiguration : IEntityTypeConfiguration<ProductionLine>
    {
        public void Configure(EntityTypeBuilder<ProductionLine> builder)
        {
            builder.ToTable(nameof(ProductionLine));
        }
    }
}
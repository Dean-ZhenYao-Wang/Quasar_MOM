using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOM.Domain.isa95.EquipmentHierarchy;

namespace MOM.Infrastructure.Persistence.Contexts.Configurations
{
    public class ProcessCellConfiguration : IEntityTypeConfiguration<ProcessCell>
    {
        public void Configure(EntityTypeBuilder<ProcessCell> builder)
        {
            builder.ToTable(nameof(ProcessCell));
        }
    }
}
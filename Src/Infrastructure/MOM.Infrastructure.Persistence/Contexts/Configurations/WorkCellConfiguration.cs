using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOM.Domain.isa95.EquipmentHierarchy;

namespace MOM.Infrastructure.Persistence.Contexts.Configurations
{
    public class WorkCellConfiguration : IEntityTypeConfiguration<WorkCell>
    {
        public void Configure(EntityTypeBuilder<WorkCell> builder)
        {
            builder.ToTable(nameof(WorkCell));
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOM.Domain.isa95.EquipmentHierarchy;

namespace MOM.Infrastructure.Persistence.Contexts.Configurations
{
    public class WorkUnitConfiguration : IEntityTypeConfiguration<WorkUnit>
    {
        public void Configure(EntityTypeBuilder<WorkUnit> builder)
        {
            builder.ToTable(nameof(WorkUnit));
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOM.Domain.isa95.EquipmentHierarchy;

namespace MOM.Infrastructure.Persistence.Contexts.Configurations
{
    public class WorkCenterConfiguration : IEntityTypeConfiguration<WorkCenter>
    {
        public void Configure(EntityTypeBuilder<WorkCenter> builder)
        {
            builder.ToTable(nameof(WorkCenter));
            builder.HasMany(hs => hs.WorkUnit)
                .WithOne(st => st.Source)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(hs => hs.SourceId);
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOM.Domain.isa95.EquipmentHierarchy;

namespace MOM.Infrastructure.Persistence.Contexts.Configurations
{
    public class AreaConfiguration : IEntityTypeConfiguration<Area>
    {
        public void Configure(EntityTypeBuilder<Area> builder)
        {
            builder.ToTable(nameof(Area));
            builder.HasMany(hs => hs.WorkCenter)
                .WithOne(st => st.Source)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(hs => hs.SourceId);
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOM.Domain.isa95.EquipmentHierarchy;

namespace MOM.Infrastructure.Persistence.Contexts.Configurations
{
    public class SiteConfiguration : IEntityTypeConfiguration<Site>
    {
        public void Configure(EntityTypeBuilder<Site> builder)
        {
            builder.ToTable(nameof(Site));
            builder.HasMany(hs => hs.Area)
                .WithOne(st => st.Source)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(hs => hs.SourceId);
        }
    }
}
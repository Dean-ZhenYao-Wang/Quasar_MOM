using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOM.Domain.isa95.EquipmentHierarchy;

namespace MOM.Infrastructure.Persistence.Contexts.Configurations
{
    public class EnterpriseConfiguration : IEntityTypeConfiguration<Enterprise>
    {
        public void Configure(EntityTypeBuilder<Enterprise> builder)
        {
            builder.ToTable(nameof(Enterprise));
            builder.HasMany(hs => hs.Site)
                .WithOne(st => st.Source)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(hs => hs.SourceId);
        }
    }
}
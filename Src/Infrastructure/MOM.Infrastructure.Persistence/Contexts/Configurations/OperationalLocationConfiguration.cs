using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOM.Domain.isa95.CommonObjectModels.Part2.OperationalLocation;

namespace MOM.Infrastructure.Persistence.Contexts.Configurations
{
    public class OperationalLocationConfiguration : IEntityTypeConfiguration<OperationalLocation>
    {
        public void Configure(EntityTypeBuilder<OperationalLocation> builder)
        {
            builder.ToTable(nameof(OperationalLocation));
            builder.HasMany(hs => hs.IsMadeUpOf)
                .WithOne(st => st.Source)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(hs => hs.SourceId);
        }
    }
}
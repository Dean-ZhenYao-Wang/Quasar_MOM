using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOM.Domain.isa95.CommonObjectModels.Part2.OperationalLocation;

namespace MOM.Infrastructure.Persistence.Contexts.Configurations
{
    public class OperationalLocationClassConfiguration : IEntityTypeConfiguration<OperationalLocationClass>
    {
        public void Configure(EntityTypeBuilder<OperationalLocationClass> builder)
        {
            builder.ToTable(nameof(OperationalLocationClass));
            builder.HasMany(hs => hs.IncludesPropertiesOf)
                .WithOne(st => st.Source)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(hs => hs.SourceId);
            builder.HasMany(hs => hs.IsMadeUpOf)
                .WithOne(st => st.Source)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(hs => hs.SourceId);
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;

namespace MOM.Infrastructure.Persistence.Contexts.Configurations
{
    public class PersonPropertyConfiguration : IEntityTypeConfiguration<PersonProperty>
    {
        public void Configure(EntityTypeBuilder<PersonProperty> builder)
        {
            builder.HasMany(p => p.Contains)
                .WithOne(c => c.Source)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(pc => pc.SourceId);
            builder.HasMany(p => p.MapsTo)
                .WithOne(c => c.Source)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(pc => pc.SourceId);
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;

namespace MOM.Infrastructure.Persistence.Contexts.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasMany(p => p.DefinedBy)
                .WithOne(c => c.Source)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(pc => pc.SourceId);
        }
    }
}
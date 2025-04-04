using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;

namespace MOM.Infrastructure.Persistence.Contexts.Configurations
{
    public class PersonnelClassPropertyConfiguration : IEntityTypeConfiguration<PersonnelClassProperty>
    {
        public void Configure(EntityTypeBuilder<PersonnelClassProperty> builder)
        {
            builder.HasMany(p => p.Contains)
                .WithOne(c => c.Source)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(pc => pc.SourceId);
        }
    }
}
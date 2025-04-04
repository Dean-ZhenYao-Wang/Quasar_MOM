using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;

namespace MOM.Infrastructure.Persistence.Contexts.Configurations
{
    public class PersonnelClassConfiguration : IEntityTypeConfiguration<PersonnelClass>
    {
        public void Configure(EntityTypeBuilder<PersonnelClass> builder)
        {
            builder.HasMany(p => p.IncludesPropertiesOf)
                .WithOne(c => c.Source)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(pc => pc.SourceId);
            builder.HasMany(p => p.HasPropertiesOf)
                .WithOne(c => c.Source)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(pc => pc.SourceId);
            builder.HasMany(p => p.HierarchyScopeRel)
                .WithOne(c => c.Source)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(pc => pc.SourceId);
        }
    }
}
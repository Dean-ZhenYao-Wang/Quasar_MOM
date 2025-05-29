using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOM.Domain.Common;

namespace MOM.Infrastructure.Persistence.Contexts.Configurations
{
    //public class WorkDefinitionConfiguration : IEntityTypeConfiguration<WorkDefinition>
    //{
    //    public void Configure(EntityTypeBuilder<WorkDefinition> builder)
    //    {
    //        //builder.UseTpcMappingStrategy();
    //    }
    //}

    public class BaseModelConfiguration : IEntityTypeConfiguration<BaseEntity>
    {
        public void Configure(EntityTypeBuilder<BaseEntity> builder)
        {
            builder.UseTpcMappingStrategy();
        }
    }

    public class BasicRelationshipConfiguration : IEntityTypeConfiguration<BasicRelationship>
    {
        public void Configure(EntityTypeBuilder<BasicRelationship> builder)
        {
            builder.UseTpcMappingStrategy();
        }
    }
}
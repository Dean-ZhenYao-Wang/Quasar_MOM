using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOM.Domain.Common;
using MOM.Domain.isa95.CommonObjectModels.Part4.WorkDefinition;

namespace MOM.Infrastructure.Persistence.Contexts.Configurations
{
    public class WorkDefinitionConfiguration : IEntityTypeConfiguration<WorkDefinition>
    {
        public void Configure(EntityTypeBuilder<WorkDefinition> builder)
        {
            //builder.UseTpcMappingStrategy();
        }
    }

    //public class BaseModelConfiguration : IEntityTypeConfiguration<BaseModel>
    //{
    //    public void Configure(EntityTypeBuilder<BaseModel> builder)
    //    {
    //        builder.UseTpcMappingStrategy();
    //    }
    //}
    public class BasicRelationshipConfiguration : IEntityTypeConfiguration<BasicRelationship>
    {
        public void Configure(EntityTypeBuilder<BasicRelationship> builder)
        {
            builder.UseTpcMappingStrategy();
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.MaterialDefinition
{
    public class MaterialDefinitionHasPropertiesOfRelationshipCollection : RelationshipCollection<MaterialDefinitionHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinitionProperty>
    {
        public MaterialDefinitionHasPropertiesOfRelationshipCollection(IEnumerable<MaterialDefinitionHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialDefinitionHasPropertiesOfRelationship>())
        {
        }
    }
}
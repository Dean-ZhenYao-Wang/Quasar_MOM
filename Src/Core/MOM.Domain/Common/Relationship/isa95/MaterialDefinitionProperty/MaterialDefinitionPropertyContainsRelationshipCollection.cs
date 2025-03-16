namespace MOM.Domain.Common.Relationship.isa95.MaterialDefinitionProperty
{
    public class MaterialDefinitionPropertyContainsRelationshipCollection : RelationshipCollection<MaterialDefinitionPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinitionProperty>
    {
        public MaterialDefinitionPropertyContainsRelationshipCollection(IEnumerable<MaterialDefinitionPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialDefinitionPropertyContainsRelationship>())
        {
        }
    }
}
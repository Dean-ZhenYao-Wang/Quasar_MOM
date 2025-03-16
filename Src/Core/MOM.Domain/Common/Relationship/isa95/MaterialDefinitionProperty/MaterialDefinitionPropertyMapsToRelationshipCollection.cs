namespace MOM.Domain.Common.Relationship.isa95.MaterialDefinitionProperty
{
    public class MaterialDefinitionPropertyMapsToRelationshipCollection : RelationshipCollection<MaterialDefinitionPropertyMapsToRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClassProperty>
    {
        public MaterialDefinitionPropertyMapsToRelationshipCollection(IEnumerable<MaterialDefinitionPropertyMapsToRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialDefinitionPropertyMapsToRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.MaterialCapabilityProperty
{
    public class MaterialCapabilityPropertyMapsToDefinitionPropertyRelationshipCollection : RelationshipCollection<MaterialCapabilityPropertyMapsToDefinitionPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinitionProperty>
    {
        public MaterialCapabilityPropertyMapsToDefinitionPropertyRelationshipCollection(IEnumerable<MaterialCapabilityPropertyMapsToDefinitionPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialCapabilityPropertyMapsToDefinitionPropertyRelationship>())
        {
        }
    }
}
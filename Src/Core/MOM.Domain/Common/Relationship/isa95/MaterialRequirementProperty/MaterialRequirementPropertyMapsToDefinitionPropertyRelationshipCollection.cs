namespace MOM.Domain.Common.Relationship.isa95.MaterialRequirementProperty
{
    public class MaterialRequirementPropertyMapsToDefinitionPropertyRelationshipCollection : RelationshipCollection<MaterialRequirementPropertyMapsToDefinitionPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinitionProperty>
    {
        public MaterialRequirementPropertyMapsToDefinitionPropertyRelationshipCollection(IEnumerable<MaterialRequirementPropertyMapsToDefinitionPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialRequirementPropertyMapsToDefinitionPropertyRelationship>())
        {
        }
    }
}
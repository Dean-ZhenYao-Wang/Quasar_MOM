namespace MOM.Domain.Common.Relationship.isa95.MaterialRequirementProperty
{
    public class MaterialRequirementPropertyMapsToClassPropertyRelationshipCollection : RelationshipCollection<MaterialRequirementPropertyMapsToClassPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClassProperty>
    {
        public MaterialRequirementPropertyMapsToClassPropertyRelationshipCollection(IEnumerable<MaterialRequirementPropertyMapsToClassPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialRequirementPropertyMapsToClassPropertyRelationship>())
        {
        }
    }
}
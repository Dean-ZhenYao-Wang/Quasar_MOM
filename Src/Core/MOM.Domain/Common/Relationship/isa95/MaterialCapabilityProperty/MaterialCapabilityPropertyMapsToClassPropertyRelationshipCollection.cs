namespace MOM.Domain.Common.Relationship.isa95.MaterialCapabilityProperty
{
    public class MaterialCapabilityPropertyMapsToClassPropertyRelationshipCollection : RelationshipCollection<MaterialCapabilityPropertyMapsToClassPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClassProperty>
    {
        public MaterialCapabilityPropertyMapsToClassPropertyRelationshipCollection(IEnumerable<MaterialCapabilityPropertyMapsToClassPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialCapabilityPropertyMapsToClassPropertyRelationship>())
        {
        }
    }
}
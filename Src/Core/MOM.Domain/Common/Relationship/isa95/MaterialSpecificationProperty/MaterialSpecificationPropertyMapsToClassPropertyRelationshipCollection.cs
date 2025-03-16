namespace MOM.Domain.Common.Relationship.isa95.MaterialSpecificationProperty
{
    public class MaterialSpecificationPropertyMapsToClassPropertyRelationshipCollection : RelationshipCollection<MaterialSpecificationPropertyMapsToClassPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClassProperty>
    {
        public MaterialSpecificationPropertyMapsToClassPropertyRelationshipCollection(IEnumerable<MaterialSpecificationPropertyMapsToClassPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSpecificationPropertyMapsToClassPropertyRelationship>())
        {
        }
    }
}
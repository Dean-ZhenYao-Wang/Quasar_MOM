namespace MOM.Domain.Common.Relationship.isa95.MaterialSegmentSpecificationProperty
{
    public class MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationshipCollection : RelationshipCollection<MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClassProperty>
    {
        public MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationshipCollection(IEnumerable<MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship>())
        {
        }
    }
}
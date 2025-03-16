namespace MOM.Domain.Common.Relationship.isa95.MaterialSegmentSpecificationProperty
{
    public class MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationshipCollection : RelationshipCollection<MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLotProperty>
    {
        public MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationshipCollection(IEnumerable<MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.MaterialSegmentSpecificationProperty
{
    public class MaterialSegmentSpecificationPropertyContainsRelationshipCollection : RelationshipCollection<MaterialSegmentSpecificationPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecificationProperty>
    {
        public MaterialSegmentSpecificationPropertyContainsRelationshipCollection(IEnumerable<MaterialSegmentSpecificationPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSegmentSpecificationPropertyContainsRelationship>())
        {
        }
    }
}
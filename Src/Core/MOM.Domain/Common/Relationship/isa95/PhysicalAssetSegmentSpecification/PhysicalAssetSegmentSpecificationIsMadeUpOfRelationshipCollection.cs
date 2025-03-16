namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSegmentSpecification
{
    public class PhysicalAssetSegmentSpecificationIsMadeUpOfRelationshipCollection : RelationshipCollection<PhysicalAssetSegmentSpecificationIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PhysicalAssetSegmentSpecification>
    {
        public PhysicalAssetSegmentSpecificationIsMadeUpOfRelationshipCollection(IEnumerable<PhysicalAssetSegmentSpecificationIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetSegmentSpecificationIsMadeUpOfRelationship>())
        {
        }
    }
}
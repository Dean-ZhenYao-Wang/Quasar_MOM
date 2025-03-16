namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSegmentSpecification
{
    public class PhysicalAssetSegmentSpecificationSpecifiesRelationshipCollection : RelationshipCollection<PhysicalAssetSegmentSpecificationSpecifiesRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification>
    {
        public PhysicalAssetSegmentSpecificationSpecifiesRelationshipCollection(IEnumerable<PhysicalAssetSegmentSpecificationSpecifiesRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetSegmentSpecificationSpecifiesRelationship>())
        {
        }
    }
}
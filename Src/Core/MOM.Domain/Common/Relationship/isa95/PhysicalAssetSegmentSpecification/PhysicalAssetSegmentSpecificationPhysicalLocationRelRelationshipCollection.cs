namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSegmentSpecification
{
    public class PhysicalAssetSegmentSpecificationPhysicalLocationRelRelationshipCollection : RelationshipCollection<PhysicalAssetSegmentSpecificationPhysicalLocationRelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>
    {
        public PhysicalAssetSegmentSpecificationPhysicalLocationRelRelationshipCollection(IEnumerable<PhysicalAssetSegmentSpecificationPhysicalLocationRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetSegmentSpecificationPhysicalLocationRelRelationship>())
        {
        }
    }
}
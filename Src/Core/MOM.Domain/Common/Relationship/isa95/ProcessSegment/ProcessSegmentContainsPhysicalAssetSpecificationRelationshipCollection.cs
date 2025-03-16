namespace MOM.Domain.Common.Relationship.isa95.ProcessSegment
{
    public class ProcessSegmentContainsPhysicalAssetSpecificationRelationshipCollection : RelationshipCollection<ProcessSegmentContainsPhysicalAssetSpecificationRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PhysicalAssetSegmentSpecification>
    {
        public ProcessSegmentContainsPhysicalAssetSpecificationRelationshipCollection(IEnumerable<ProcessSegmentContainsPhysicalAssetSpecificationRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ProcessSegmentContainsPhysicalAssetSpecificationRelationship>())
        {
        }
    }
}
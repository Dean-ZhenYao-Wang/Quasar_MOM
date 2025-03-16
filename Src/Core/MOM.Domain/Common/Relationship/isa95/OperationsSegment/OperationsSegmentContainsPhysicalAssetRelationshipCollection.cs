namespace MOM.Domain.Common.Relationship.isa95.OperationsSegment
{
    public class OperationsSegmentContainsPhysicalAssetRelationshipCollection : RelationshipCollection<OperationsSegmentContainsPhysicalAssetRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PhysicalAssetSpecification>
    {
        public OperationsSegmentContainsPhysicalAssetRelationshipCollection(IEnumerable<OperationsSegmentContainsPhysicalAssetRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsSegmentContainsPhysicalAssetRelationship>())
        {
        }
    }
}
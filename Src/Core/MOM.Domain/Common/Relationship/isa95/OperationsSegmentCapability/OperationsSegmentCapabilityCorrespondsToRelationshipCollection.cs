namespace MOM.Domain.Common.Relationship.isa95.OperationsSegmentCapability
{
    public class OperationsSegmentCapabilityCorrespondsToRelationshipCollection : RelationshipCollection<OperationsSegmentCapabilityCorrespondsToRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment>
    {
        public OperationsSegmentCapabilityCorrespondsToRelationshipCollection(IEnumerable<OperationsSegmentCapabilityCorrespondsToRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsSegmentCapabilityCorrespondsToRelationship>())
        {
        }
    }
}
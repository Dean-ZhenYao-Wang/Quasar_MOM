namespace MOM.Domain.Common.Relationship.isa95.ProcessSegmentCapability
{
    public class ProcessSegmentCapabilityCorrespondsToRelationshipCollection : RelationshipCollection<ProcessSegmentCapabilityCorrespondsToRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment>
    {
        public ProcessSegmentCapabilityCorrespondsToRelationshipCollection(IEnumerable<ProcessSegmentCapabilityCorrespondsToRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ProcessSegmentCapabilityCorrespondsToRelationship>())
        {
        }
    }
}
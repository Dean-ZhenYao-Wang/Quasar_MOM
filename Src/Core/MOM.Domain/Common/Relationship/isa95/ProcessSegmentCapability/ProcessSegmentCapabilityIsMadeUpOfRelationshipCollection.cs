namespace MOM.Domain.Common.Relationship.isa95.ProcessSegmentCapability
{
    public class ProcessSegmentCapabilityIsMadeUpOfRelationshipCollection : RelationshipCollection<ProcessSegmentCapabilityIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.ProcessSegmentCapability>
    {
        public ProcessSegmentCapabilityIsMadeUpOfRelationshipCollection(IEnumerable<ProcessSegmentCapabilityIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ProcessSegmentCapabilityIsMadeUpOfRelationship>())
        {
        }
    }
}
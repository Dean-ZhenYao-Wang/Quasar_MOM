namespace MOM.Domain.Common.Relationship.isa95.OperationsSegmentCapability
{
    public class OperationsSegmentCapabilityIsMadeUpOfRelationshipCollection : RelationshipCollection<OperationsSegmentCapabilityIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.OperationsSegmentCapability>
    {
        public OperationsSegmentCapabilityIsMadeUpOfRelationshipCollection(IEnumerable<OperationsSegmentCapabilityIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsSegmentCapabilityIsMadeUpOfRelationship>())
        {
        }
    }
}
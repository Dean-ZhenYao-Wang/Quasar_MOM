namespace MOM.Domain.Common.Relationship.isa95.OperationsCapability
{
    public class OperationsCapabilityIsACollectionOfOperationsRelationshipCollection : RelationshipCollection<OperationsCapabilityIsACollectionOfOperationsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.OperationsSegmentCapability>
    {
        public OperationsCapabilityIsACollectionOfOperationsRelationshipCollection(IEnumerable<OperationsCapabilityIsACollectionOfOperationsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsCapabilityIsACollectionOfOperationsRelationship>())
        {
        }
    }
}
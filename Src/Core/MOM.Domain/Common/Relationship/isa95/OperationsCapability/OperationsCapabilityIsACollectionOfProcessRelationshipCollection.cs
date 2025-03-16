namespace MOM.Domain.Common.Relationship.isa95.OperationsCapability
{
    public class OperationsCapabilityIsACollectionOfProcessRelationshipCollection : RelationshipCollection<OperationsCapabilityIsACollectionOfProcessRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.ProcessSegmentCapability>
    {
        public OperationsCapabilityIsACollectionOfProcessRelationshipCollection(IEnumerable<OperationsCapabilityIsACollectionOfProcessRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsCapabilityIsACollectionOfProcessRelationship>())
        {
        }
    }
}
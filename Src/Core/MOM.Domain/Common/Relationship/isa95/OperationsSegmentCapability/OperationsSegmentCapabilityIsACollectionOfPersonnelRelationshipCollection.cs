namespace MOM.Domain.Common.Relationship.isa95.OperationsSegmentCapability
{
    public class OperationsSegmentCapabilityIsACollectionOfPersonnelRelationshipCollection : RelationshipCollection<OperationsSegmentCapabilityIsACollectionOfPersonnelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PersonnelCapability>
    {
        public OperationsSegmentCapabilityIsACollectionOfPersonnelRelationshipCollection(IEnumerable<OperationsSegmentCapabilityIsACollectionOfPersonnelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsSegmentCapabilityIsACollectionOfPersonnelRelationship>())
        {
        }
    }
}
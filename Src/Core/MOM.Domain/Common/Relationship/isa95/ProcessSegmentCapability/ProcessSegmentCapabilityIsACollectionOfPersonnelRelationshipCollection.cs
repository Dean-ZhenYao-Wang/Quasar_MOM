namespace MOM.Domain.Common.Relationship.isa95.ProcessSegmentCapability
{
    public class ProcessSegmentCapabilityIsACollectionOfPersonnelRelationshipCollection : RelationshipCollection<ProcessSegmentCapabilityIsACollectionOfPersonnelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PersonnelCapability>
    {
        public ProcessSegmentCapabilityIsACollectionOfPersonnelRelationshipCollection(IEnumerable<ProcessSegmentCapabilityIsACollectionOfPersonnelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ProcessSegmentCapabilityIsACollectionOfPersonnelRelationship>())
        {
        }
    }
}
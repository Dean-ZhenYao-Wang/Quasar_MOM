namespace MOM.Domain.Common.Relationship.isa95.WorkCapability
{
    public class WorkCapabilityIsACollectionOfPersonnelRelationshipCollection : RelationshipCollection<WorkCapabilityIsACollectionOfPersonnelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PersonnelCapability>
    {
        public WorkCapabilityIsACollectionOfPersonnelRelationshipCollection(IEnumerable<WorkCapabilityIsACollectionOfPersonnelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkCapabilityIsACollectionOfPersonnelRelationship>())
        {
        }
    }
}
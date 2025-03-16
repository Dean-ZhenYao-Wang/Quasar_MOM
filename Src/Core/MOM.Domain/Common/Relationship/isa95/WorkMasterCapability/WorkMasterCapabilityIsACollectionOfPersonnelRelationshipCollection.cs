namespace MOM.Domain.Common.Relationship.isa95.WorkMasterCapability
{
    public class WorkMasterCapabilityIsACollectionOfPersonnelRelationshipCollection : RelationshipCollection<WorkMasterCapabilityIsACollectionOfPersonnelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PersonnelCapability>
    {
        public WorkMasterCapabilityIsACollectionOfPersonnelRelationshipCollection(IEnumerable<WorkMasterCapabilityIsACollectionOfPersonnelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkMasterCapabilityIsACollectionOfPersonnelRelationship>())
        {
        }
    }
}
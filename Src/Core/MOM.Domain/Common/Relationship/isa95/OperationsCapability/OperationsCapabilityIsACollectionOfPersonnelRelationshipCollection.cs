namespace MOM.Domain.Common.Relationship.isa95.OperationsCapability
{
    public class OperationsCapabilityIsACollectionOfPersonnelRelationshipCollection : RelationshipCollection<OperationsCapabilityIsACollectionOfPersonnelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PersonnelCapability>
    {
        public OperationsCapabilityIsACollectionOfPersonnelRelationshipCollection(IEnumerable<OperationsCapabilityIsACollectionOfPersonnelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsCapabilityIsACollectionOfPersonnelRelationship>())
        {
        }
    }
}
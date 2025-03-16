namespace MOM.Domain.Common.Relationship.isa95.WorkMasterCapability
{
    public class WorkMasterCapabilityIsMadeUpOfRelationshipCollection : RelationshipCollection<WorkMasterCapabilityIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part4.WorkCapability.WorkMasterCapability>
    {
        public WorkMasterCapabilityIsMadeUpOfRelationshipCollection(IEnumerable<WorkMasterCapabilityIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkMasterCapabilityIsMadeUpOfRelationship>())
        {
        }
    }
}
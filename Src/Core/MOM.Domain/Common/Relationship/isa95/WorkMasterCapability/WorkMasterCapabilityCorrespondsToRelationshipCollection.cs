namespace MOM.Domain.Common.Relationship.isa95.WorkMasterCapability
{
    public class WorkMasterCapabilityCorrespondsToRelationshipCollection : RelationshipCollection<WorkMasterCapabilityCorrespondsToRelationship, Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkMaster>
    {
        public WorkMasterCapabilityCorrespondsToRelationshipCollection(IEnumerable<WorkMasterCapabilityCorrespondsToRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkMasterCapabilityCorrespondsToRelationship>())
        {
        }
    }
}
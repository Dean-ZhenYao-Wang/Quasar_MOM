namespace MOM.Domain.Common.Relationship.isa95.WorkCapability
{
    public class WorkCapabilityIsACollectionOfWorkMasterRelationshipCollection : RelationshipCollection<WorkCapabilityIsACollectionOfWorkMasterRelationship, Domain.isa95.CommonObjectModels.Part4.WorkCapability.WorkMasterCapability>
    {
        public WorkCapabilityIsACollectionOfWorkMasterRelationshipCollection(IEnumerable<WorkCapabilityIsACollectionOfWorkMasterRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkCapabilityIsACollectionOfWorkMasterRelationship>())
        {
        }
    }
}
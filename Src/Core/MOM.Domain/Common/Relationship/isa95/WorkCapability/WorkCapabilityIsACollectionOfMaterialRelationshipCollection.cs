namespace MOM.Domain.Common.Relationship.isa95.WorkCapability
{
    public class WorkCapabilityIsACollectionOfMaterialRelationshipCollection : RelationshipCollection<WorkCapabilityIsACollectionOfMaterialRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapability>
    {
        public WorkCapabilityIsACollectionOfMaterialRelationshipCollection(IEnumerable<WorkCapabilityIsACollectionOfMaterialRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkCapabilityIsACollectionOfMaterialRelationship>())
        {
        }
    }
}
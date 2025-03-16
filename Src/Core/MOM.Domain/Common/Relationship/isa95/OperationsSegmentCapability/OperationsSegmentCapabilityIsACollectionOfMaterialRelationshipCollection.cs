namespace MOM.Domain.Common.Relationship.isa95.OperationsSegmentCapability
{
    public class OperationsSegmentCapabilityIsACollectionOfMaterialRelationshipCollection : RelationshipCollection<OperationsSegmentCapabilityIsACollectionOfMaterialRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapability>
    {
        public OperationsSegmentCapabilityIsACollectionOfMaterialRelationshipCollection(IEnumerable<OperationsSegmentCapabilityIsACollectionOfMaterialRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsSegmentCapabilityIsACollectionOfMaterialRelationship>())
        {
        }
    }
}
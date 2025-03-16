namespace MOM.Domain.Common.Relationship.isa95.ProcessSegmentCapability
{
    public class ProcessSegmentCapabilityIsACollectionOfMaterialRelationshipCollection : RelationshipCollection<ProcessSegmentCapabilityIsACollectionOfMaterialRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapability>
    {
        public ProcessSegmentCapabilityIsACollectionOfMaterialRelationshipCollection(IEnumerable<ProcessSegmentCapabilityIsACollectionOfMaterialRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ProcessSegmentCapabilityIsACollectionOfMaterialRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.OperationsCapability
{
    public class OperationsCapabilityIsACollectionOfMaterialRelationshipCollection : RelationshipCollection<OperationsCapabilityIsACollectionOfMaterialRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.MaterialCapability>
    {
        public OperationsCapabilityIsACollectionOfMaterialRelationshipCollection(IEnumerable<OperationsCapabilityIsACollectionOfMaterialRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsCapabilityIsACollectionOfMaterialRelationship>())
        {
        }
    }
}
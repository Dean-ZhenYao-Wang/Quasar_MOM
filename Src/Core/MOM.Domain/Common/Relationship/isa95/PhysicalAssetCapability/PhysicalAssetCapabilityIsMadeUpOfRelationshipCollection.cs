namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetCapability
{
    public class PhysicalAssetCapabilityIsMadeUpOfRelationshipCollection : RelationshipCollection<PhysicalAssetCapabilityIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PhysicalAssetCapability>
    {
        public PhysicalAssetCapabilityIsMadeUpOfRelationshipCollection(IEnumerable<PhysicalAssetCapabilityIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetCapabilityIsMadeUpOfRelationship>())
        {
        }
    }
}
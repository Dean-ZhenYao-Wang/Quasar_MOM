namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetCapabilityProperty
{
    public class PhysicalAssetCapabilityPropertyContainsRelationshipCollection : RelationshipCollection<PhysicalAssetCapabilityPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PhysicalAssetCapabilityProperty>
    {
        public PhysicalAssetCapabilityPropertyContainsRelationshipCollection(IEnumerable<PhysicalAssetCapabilityPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetCapabilityPropertyContainsRelationship>())
        {
        }
    }
}
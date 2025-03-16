namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetCapability
{
    public class PhysicalAssetCapabilityPhysicalLocationRelRelationshipCollection : RelationshipCollection<PhysicalAssetCapabilityPhysicalLocationRelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>
    {
        public PhysicalAssetCapabilityPhysicalLocationRelRelationshipCollection(IEnumerable<PhysicalAssetCapabilityPhysicalLocationRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetCapabilityPhysicalLocationRelRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetCapability
{
    public class PhysicalAssetCapabilityHasValuesOfRelationshipCollection : RelationshipCollection<PhysicalAssetCapabilityHasValuesOfRelationship, MOM.Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PhysicalAssetCapabilityProperty>
    {
        public PhysicalAssetCapabilityHasValuesOfRelationshipCollection(IEnumerable<PhysicalAssetCapabilityHasValuesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetCapabilityHasValuesOfRelationship>())
        {
        }
    }
}
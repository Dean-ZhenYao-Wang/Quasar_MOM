namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSpecification
{
    public class PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationshipCollection : RelationshipCollection<PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass>
    {
        public PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationshipCollection(IEnumerable<PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship>())
        {
        }
    }
}
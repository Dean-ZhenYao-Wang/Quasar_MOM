namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSpecification
{
    public class PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationshipCollection : RelationshipCollection<PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset>
    {
        public PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationshipCollection(IEnumerable<PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship>())
        {
        }
    }
}
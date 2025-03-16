namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSegmentSpecification
{
    public class PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetRelationshipCollection : RelationshipCollection<PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset>
    {
        public PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetRelationshipCollection(IEnumerable<PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetRelationship>())
        {
        }
    }
}
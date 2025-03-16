namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSegmentSpecification
{
    public class PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetClassRelationshipCollection : RelationshipCollection<PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetClassRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass>
    {
        public PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetClassRelationshipCollection(IEnumerable<PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetClassRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetClassRelationship>())
        {
        }
    }
}
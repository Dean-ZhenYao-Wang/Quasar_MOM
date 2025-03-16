namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetActual
{
    public class PhysicalAssetActualCorrespondsToPhysicalAssetClassRelationshipCollection : RelationshipCollection<PhysicalAssetActualCorrespondsToPhysicalAssetClassRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass>
    {
        public PhysicalAssetActualCorrespondsToPhysicalAssetClassRelationshipCollection(IEnumerable<PhysicalAssetActualCorrespondsToPhysicalAssetClassRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetActualCorrespondsToPhysicalAssetClassRelationship>())
        {
        }
    }
}
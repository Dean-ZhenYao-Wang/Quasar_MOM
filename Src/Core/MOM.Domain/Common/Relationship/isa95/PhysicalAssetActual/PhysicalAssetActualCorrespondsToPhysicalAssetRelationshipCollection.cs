namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetActual
{
    public class PhysicalAssetActualCorrespondsToPhysicalAssetRelationshipCollection : RelationshipCollection<PhysicalAssetActualCorrespondsToPhysicalAssetRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset>
    {
        public PhysicalAssetActualCorrespondsToPhysicalAssetRelationshipCollection(IEnumerable<PhysicalAssetActualCorrespondsToPhysicalAssetRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetActualCorrespondsToPhysicalAssetRelationship>())
        {
        }
    }
}
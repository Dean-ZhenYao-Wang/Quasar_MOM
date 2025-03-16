namespace MOM.Domain.Common.Relationship.isa95.EquipmentAssetMapping
{
    public class EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationshipCollection : RelationshipCollection<EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset>
    {
        public EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationshipCollection(IEnumerable<EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship>())
        {
        }
    }
}
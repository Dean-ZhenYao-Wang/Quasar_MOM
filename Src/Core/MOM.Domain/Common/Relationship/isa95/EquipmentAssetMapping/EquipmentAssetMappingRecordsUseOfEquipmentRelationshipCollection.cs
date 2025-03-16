namespace MOM.Domain.Common.Relationship.isa95.EquipmentAssetMapping
{
    public class EquipmentAssetMappingRecordsUseOfEquipmentRelationshipCollection : RelationshipCollection<EquipmentAssetMappingRecordsUseOfEquipmentRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment>
    {
        public EquipmentAssetMappingRecordsUseOfEquipmentRelationshipCollection(IEnumerable<EquipmentAssetMappingRecordsUseOfEquipmentRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentAssetMappingRecordsUseOfEquipmentRelationship>())
        {
        }
    }
}
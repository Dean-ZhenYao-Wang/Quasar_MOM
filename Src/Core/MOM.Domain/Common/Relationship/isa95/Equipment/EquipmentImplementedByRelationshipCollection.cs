namespace MOM.Domain.Common.Relationship.isa95.Equipment
{
    public class EquipmentImplementedByRelationshipCollection : RelationshipCollection<EquipmentImplementedByRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset>
    {
        public EquipmentImplementedByRelationshipCollection(IEnumerable<EquipmentImplementedByRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EquipmentImplementedByRelationship>())
        {
        }
    }
}
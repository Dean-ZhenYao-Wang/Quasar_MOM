namespace MOM.Domain.Common.Relationship.isa95.EquipmentAssetMapping
{
    public class EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset>, IEquatable<EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship>
    {
        public EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship()
        {
            Name = "RecordsUseOfPhysicalAsset";
        }

        public EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship(MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentAssetMapping source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship);
        }

        public bool Equals(EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship? left, EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship? right)
        {
            return EqualityComparer<EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship? left, EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
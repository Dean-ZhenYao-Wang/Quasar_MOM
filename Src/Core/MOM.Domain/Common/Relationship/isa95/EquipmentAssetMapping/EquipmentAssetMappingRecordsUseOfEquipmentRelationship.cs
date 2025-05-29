namespace MOM.Domain.Common.Relationship.isa95.EquipmentAssetMapping
{
    public class EquipmentAssetMappingRecordsUseOfEquipmentRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentAssetMapping ,Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment>, IEquatable<EquipmentAssetMappingRecordsUseOfEquipmentRelationship>
    {
        public EquipmentAssetMappingRecordsUseOfEquipmentRelationship()
        {
            Name = "RecordsUseOfEquipment";
        }

        public EquipmentAssetMappingRecordsUseOfEquipmentRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentAssetMapping source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public EquipmentAssetMappingRecordsUseOfEquipmentRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentAssetMappingRecordsUseOfEquipmentRelationship);
        }

        public bool Equals(EquipmentAssetMappingRecordsUseOfEquipmentRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(EquipmentAssetMappingRecordsUseOfEquipmentRelationship? left, EquipmentAssetMappingRecordsUseOfEquipmentRelationship? right)
        {
            return EqualityComparer<EquipmentAssetMappingRecordsUseOfEquipmentRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentAssetMappingRecordsUseOfEquipmentRelationship? left, EquipmentAssetMappingRecordsUseOfEquipmentRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentAssetMappingRecordsUseOfEquipmentRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
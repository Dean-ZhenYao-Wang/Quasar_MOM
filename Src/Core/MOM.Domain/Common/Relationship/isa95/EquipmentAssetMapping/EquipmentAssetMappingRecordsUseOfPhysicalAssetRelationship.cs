
namespace MOM.Domain.Common.Relationship.isa95.EquipmentAssetMapping
{
    /// <summary>
    /// 
    /// </summary>
    public class EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship : Relationship<MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentAssetMapping,Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset>, IEquatable<EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship>
    {
        /// <inheritdoc/>
        public EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship()
        {
            Name = "RecordsUseOfPhysicalAsset";
        }

        /// <inheritdoc/>
        public EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentAssetMapping source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset target) : base(source, target)
        {
        }

        /// <inheritdoc/>
        public EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship(Guid sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }

        /// <inheritdoc/>
        public EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship(Guid sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }

        /// <inheritdoc/>
        public EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship(Guid sourceId, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset target, int depth) : base(sourceId, target, depth)
        {
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship);
        }

        /// <inheritdoc/>
        public bool Equals(EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        /// <inheritdoc/>
        public static bool operator ==(EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship? left, EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship? right)
        {
            return EqualityComparer<EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship? left, EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship? right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        /// <inheritdoc/>
        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
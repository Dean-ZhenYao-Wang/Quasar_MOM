
namespace MOM.Domain.Common.Relationship.isa95.Equipment
{
    /// <summary>
    /// 
    /// </summary>
    public class EquipmentImplementedByRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment,Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset>, IEquatable<EquipmentImplementedByRelationship>
    {
        /// <inheritdoc/>
        public override string Name { get; set; } = "implementedBy";
        /// <inheritdoc/>

        public EquipmentImplementedByRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset target) : base(source, target)
        {
        }
        /// <inheritdoc/>
        public EquipmentImplementedByRelationship(Guid sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }
        /// <inheritdoc/>
        public EquipmentImplementedByRelationship(Guid sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }
        /// <inheritdoc/>
        public EquipmentImplementedByRelationship(Guid sourceId, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset target, int depth) : base(sourceId, target, depth)
        {
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentImplementedByRelationship);
        }

        /// <inheritdoc/>
        public bool Equals(EquipmentImplementedByRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        /// <inheritdoc/>
        public static bool operator ==(EquipmentImplementedByRelationship? left, EquipmentImplementedByRelationship? right)
        {
            return EqualityComparer<EquipmentImplementedByRelationship?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(EquipmentImplementedByRelationship? left, EquipmentImplementedByRelationship? right)
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
            return Equals(other as EquipmentImplementedByRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
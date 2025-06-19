
namespace MOM.Domain.Common.Relationship.isa95.Equipment
{
    /// <summary>
    /// 
    /// </summary>
    public class EquipmentDefinedByRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass>, IEquatable<EquipmentDefinedByRelationship>
    {
        /// <inheritdoc/>
        public EquipmentDefinedByRelationship()
        {
            Name = "definedBy";
        }
        /// <inheritdoc/>
        public EquipmentDefinedByRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass target) : base(source, target)
        {
        }
        /// <inheritdoc/>
        public EquipmentDefinedByRelationship(Guid sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }
        /// <inheritdoc/>
        public EquipmentDefinedByRelationship(Guid sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }
        /// <inheritdoc/>
        public EquipmentDefinedByRelationship(Guid sourceId, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass target, int depth) : base(sourceId, target, depth)
        {
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentDefinedByRelationship);
        }
        /// <inheritdoc/>
        public bool Equals(EquipmentDefinedByRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }
        /// <inheritdoc/>
        public static bool operator ==(EquipmentDefinedByRelationship? left, EquipmentDefinedByRelationship? right)
        {
            return EqualityComparer<EquipmentDefinedByRelationship?>.Default.Equals(left, right);
        }
        /// <inheritdoc/>
        public static bool operator !=(EquipmentDefinedByRelationship? left, EquipmentDefinedByRelationship? right)
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
            return Equals(other as EquipmentDefinedByRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
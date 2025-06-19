
namespace MOM.Domain.Common.Relationship.isa95.Equipment
{
    /// <summary>
    /// 
    /// </summary>
    public class EquipmentIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment ,Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment>, IEquatable<EquipmentIsMadeUpOfRelationship>
    {
        /// <inheritdoc/>
        public EquipmentIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }
        /// <inheritdoc/>
        public EquipmentIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment target) : base(source, target)
        {
        }
        /// <inheritdoc/>
        public EquipmentIsMadeUpOfRelationship(Guid sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }
        /// <inheritdoc/>
        public EquipmentIsMadeUpOfRelationship(Guid sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }
        /// <inheritdoc/>
        public EquipmentIsMadeUpOfRelationship(Guid sourceId, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment target, int depth) : base(sourceId, target, depth)
        {
        }


        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentIsMadeUpOfRelationship);
        }

        /// <inheritdoc/>
        public bool Equals(EquipmentIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        /// <inheritdoc/>
        public static bool operator ==(EquipmentIsMadeUpOfRelationship? left, EquipmentIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<EquipmentIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(EquipmentIsMadeUpOfRelationship? left, EquipmentIsMadeUpOfRelationship? right)
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
            return Equals(other as EquipmentIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
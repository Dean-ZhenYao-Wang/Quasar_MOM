
namespace MOM.Domain.Common.Relationship.isa95.EquipmentClass
{
    /// <summary>
    /// 
    /// </summary>
    public class EquipmentClassIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass,Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass>, IEquatable<EquipmentClassIsMadeUpOfRelationship>
    {
        /// <inheritdoc/>
        public EquipmentClassIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        /// <inheritdoc/>
        public EquipmentClassIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass target) : base(source, target)
        {
        }

        /// <inheritdoc/>
        public EquipmentClassIsMadeUpOfRelationship(Guid sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }

        /// <inheritdoc/>
        public EquipmentClassIsMadeUpOfRelationship(Guid sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }

        /// <inheritdoc/>
        public EquipmentClassIsMadeUpOfRelationship(Guid sourceId, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass target, int depth) : base(sourceId, target, depth)
        {
        }


        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentClassIsMadeUpOfRelationship);
        }

        /// <inheritdoc/>
        public bool Equals(EquipmentClassIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        /// <inheritdoc/>
        public static bool operator ==(EquipmentClassIsMadeUpOfRelationship? left, EquipmentClassIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<EquipmentClassIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(EquipmentClassIsMadeUpOfRelationship? left, EquipmentClassIsMadeUpOfRelationship? right)
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
            return Equals(other as EquipmentClassIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
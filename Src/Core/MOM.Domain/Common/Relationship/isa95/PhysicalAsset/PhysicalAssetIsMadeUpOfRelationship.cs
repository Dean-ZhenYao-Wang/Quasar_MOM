namespace MOM.Domain.Common.Relationship.isa95.PhysicalAsset
{
    /// <summary>
    ///
    /// </summary>
    public class PhysicalAssetIsMadeUpOfRelationship : Relationship<MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset>, IEquatable<PhysicalAssetIsMadeUpOfRelationship>
    {
        /// <inheritdoc/>
        public override string Name { get; set; } = "isMadeUpOf";

        /// <inheritdoc/>
        public PhysicalAssetIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset target) : base(source, target)
        {
        }

        /// <inheritdoc/>
        public PhysicalAssetIsMadeUpOfRelationship(Guid sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }

        /// <inheritdoc/>
        public PhysicalAssetIsMadeUpOfRelationship(Guid sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }

        /// <inheritdoc/>
        public PhysicalAssetIsMadeUpOfRelationship(Guid sourceId, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset target, int depth) : base(sourceId, target, depth)
        {
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetIsMadeUpOfRelationship);
        }

        /// <inheritdoc/>
        public bool Equals(PhysicalAssetIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        /// <inheritdoc/>
        public static bool operator ==(PhysicalAssetIsMadeUpOfRelationship? left, PhysicalAssetIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<PhysicalAssetIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(PhysicalAssetIsMadeUpOfRelationship? left, PhysicalAssetIsMadeUpOfRelationship? right)
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
            return Equals(other as PhysicalAssetIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
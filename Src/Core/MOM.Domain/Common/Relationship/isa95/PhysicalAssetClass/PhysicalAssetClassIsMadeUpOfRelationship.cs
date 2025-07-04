namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetClass
{
    /// <summary>
    ///
    /// </summary>
    public class PhysicalAssetClassIsMadeUpOfRelationship : Relationship<MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass>, IEquatable<PhysicalAssetClassIsMadeUpOfRelationship>
    {
        /// <inheritdoc/>
        public override string Name { get; set; } = "isMadeUpOf";

        /// <inheritdoc/>
        public PhysicalAssetClassIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass target) : base(source, target)
        {
        }

        /// <inheritdoc/>
        public PhysicalAssetClassIsMadeUpOfRelationship(Guid sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }

        /// <inheritdoc/>
        public PhysicalAssetClassIsMadeUpOfRelationship(Guid sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }

        /// <inheritdoc/>
        public PhysicalAssetClassIsMadeUpOfRelationship(Guid sourceId, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass target, int depth) : base(sourceId, target, depth)
        {
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetClassIsMadeUpOfRelationship);
        }

        /// <inheritdoc/>
        public bool Equals(PhysicalAssetClassIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        /// <inheritdoc/>
        public static bool operator ==(PhysicalAssetClassIsMadeUpOfRelationship? left, PhysicalAssetClassIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<PhysicalAssetClassIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(PhysicalAssetClassIsMadeUpOfRelationship? left, PhysicalAssetClassIsMadeUpOfRelationship? right)
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
            return Equals(other as PhysicalAssetClassIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
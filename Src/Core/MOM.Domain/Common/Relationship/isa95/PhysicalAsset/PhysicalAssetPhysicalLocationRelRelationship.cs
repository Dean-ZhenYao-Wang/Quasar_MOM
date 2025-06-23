namespace MOM.Domain.Common.Relationship.isa95.PhysicalAsset
{
    /// <summary>
    ///
    /// </summary>
    public class PhysicalAssetPhysicalLocationRelRelationship : Relationship<MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>, IEquatable<PhysicalAssetPhysicalLocationRelRelationship>
    {
        /// <inheritdoc/>
        public override string Name { get; set; } = "physicalLocationRel";

        /// <inheritdoc/>
        public PhysicalAssetPhysicalLocationRelRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation target) : base(source, target)
        {
        }

        /// <inheritdoc/>
        public PhysicalAssetPhysicalLocationRelRelationship(Guid sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }

        /// <inheritdoc/>
        public PhysicalAssetPhysicalLocationRelRelationship(Guid sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }

        /// <inheritdoc/>
        public PhysicalAssetPhysicalLocationRelRelationship(Guid sourceId, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation target, int depth) : base(sourceId, target, depth)
        {
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetPhysicalLocationRelRelationship);
        }

        /// <inheritdoc/>
        public bool Equals(PhysicalAssetPhysicalLocationRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        /// <inheritdoc/>
        public static bool operator ==(PhysicalAssetPhysicalLocationRelRelationship? left, PhysicalAssetPhysicalLocationRelRelationship? right)
        {
            return EqualityComparer<PhysicalAssetPhysicalLocationRelRelationship?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(PhysicalAssetPhysicalLocationRelRelationship? left, PhysicalAssetPhysicalLocationRelRelationship? right)
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
            return Equals(other as PhysicalAssetPhysicalLocationRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
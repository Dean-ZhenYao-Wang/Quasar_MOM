namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetClass
{
    /// <summary>
    ///
    /// </summary>
    public class PhysicalAssetClassIncludesPropertiesOfRelationship : Relationship<MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass>, IEquatable<PhysicalAssetClassIncludesPropertiesOfRelationship>
    {
        /// <inheritdoc/>
        public override string Name { get; set; } = "includesPropertiesOf";

        /// <inheritdoc/>
        public PhysicalAssetClassIncludesPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass source, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass target) : base(source, target)
        {
        }

        /// <inheritdoc/>
        public PhysicalAssetClassIncludesPropertiesOfRelationship(Guid sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }

        /// <inheritdoc/>
        public PhysicalAssetClassIncludesPropertiesOfRelationship(Guid sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }

        /// <inheritdoc/>
        public PhysicalAssetClassIncludesPropertiesOfRelationship(Guid sourceId, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass target, int depth) : base(sourceId, target, depth)
        {
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetClassIncludesPropertiesOfRelationship);
        }

        /// <inheritdoc/>
        public bool Equals(PhysicalAssetClassIncludesPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        /// <inheritdoc/>
        public static bool operator ==(PhysicalAssetClassIncludesPropertiesOfRelationship? left, PhysicalAssetClassIncludesPropertiesOfRelationship? right)
        {
            return EqualityComparer<PhysicalAssetClassIncludesPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(PhysicalAssetClassIncludesPropertiesOfRelationship? left, PhysicalAssetClassIncludesPropertiesOfRelationship? right)
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
            return Equals(other as PhysicalAssetClassIncludesPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
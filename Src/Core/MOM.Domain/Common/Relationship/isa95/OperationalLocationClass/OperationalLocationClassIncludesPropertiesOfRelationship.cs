namespace MOM.Domain.Common.Relationship.isa95.OperationalLocationClass
{
    /// <summary>
    ///
    /// </summary>
    public class OperationalLocationClassIncludesPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClass, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClass>, IEquatable<OperationalLocationClassIncludesPropertiesOfRelationship>
    {
        /// <inheritdoc/>
        public override string Name { get; set; } = "includesPropertiesOf";

        /// <inheritdoc/>
        public OperationalLocationClassIncludesPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClass source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClass target) : base(source, target)
        {
        }

        /// <inheritdoc/>
        public OperationalLocationClassIncludesPropertiesOfRelationship(Guid sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }

        /// <inheritdoc/>
        public OperationalLocationClassIncludesPropertiesOfRelationship(Guid sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }

        /// <inheritdoc/>
        public OperationalLocationClassIncludesPropertiesOfRelationship(Guid sourceId, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClass target, int depth) : base(sourceId, target, depth)
        {
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationalLocationClassIncludesPropertiesOfRelationship);
        }

        /// <inheritdoc/>
        public bool Equals(OperationalLocationClassIncludesPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        /// <inheritdoc/>
        public static bool operator ==(OperationalLocationClassIncludesPropertiesOfRelationship? left, OperationalLocationClassIncludesPropertiesOfRelationship? right)
        {
            return EqualityComparer<OperationalLocationClassIncludesPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(OperationalLocationClassIncludesPropertiesOfRelationship? left, OperationalLocationClassIncludesPropertiesOfRelationship? right)
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
            return Equals(other as OperationalLocationClassIncludesPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.OperationalLocation
{
    /// <summary>
    ///
    /// </summary>
    public class OperationalLocationDefinedByRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClass>, IEquatable<OperationalLocationDefinedByRelationship>
    {
        /// <inheritdoc/>
        public override string Name { get; set; } = "definedBy";

        /// <inheritdoc/>
        public OperationalLocationDefinedByRelationship(Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClass target) : base(source, target)
        {
        }

        /// <inheritdoc/>
        public OperationalLocationDefinedByRelationship(Guid sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }

        /// <inheritdoc/>
        public OperationalLocationDefinedByRelationship(Guid sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }

        /// <inheritdoc/>
        public OperationalLocationDefinedByRelationship(Guid sourceId, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClass target, int depth) : base(sourceId, target, depth)
        {
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationalLocationDefinedByRelationship);
        }

        /// <inheritdoc/>
        public bool Equals(OperationalLocationDefinedByRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        /// <inheritdoc/>
        public static bool operator ==(OperationalLocationDefinedByRelationship? left, OperationalLocationDefinedByRelationship? right)
        {
            return EqualityComparer<OperationalLocationDefinedByRelationship?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(OperationalLocationDefinedByRelationship? left, OperationalLocationDefinedByRelationship? right)
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
            return Equals(other as OperationalLocationDefinedByRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
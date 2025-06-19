
namespace MOM.Domain.Common.Relationship.isa95.OperationalLocation
{
    /// <summary>
    /// 
    /// </summary>
    public class OperationalLocationIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation ,Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>, IEquatable<OperationalLocationIsMadeUpOfRelationship>
    {
        /// <inheritdoc/>
        public OperationalLocationIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }
        /// <inheritdoc/>
        public OperationalLocationIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation target) : base(source, target)
        {
        }
        /// <inheritdoc/>
        public OperationalLocationIsMadeUpOfRelationship(Guid sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }
        /// <inheritdoc/>
        public OperationalLocationIsMadeUpOfRelationship(Guid sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }
        /// <inheritdoc/>
        public OperationalLocationIsMadeUpOfRelationship(Guid sourceId, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation target, int depth) : base(sourceId, target, depth)
        {
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationalLocationIsMadeUpOfRelationship);
        }

        /// <inheritdoc/>
        public bool Equals(OperationalLocationIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        /// <inheritdoc/>
        public static bool operator ==(OperationalLocationIsMadeUpOfRelationship? left, OperationalLocationIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<OperationalLocationIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(OperationalLocationIsMadeUpOfRelationship? left, OperationalLocationIsMadeUpOfRelationship? right)
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
            return Equals(other as OperationalLocationIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
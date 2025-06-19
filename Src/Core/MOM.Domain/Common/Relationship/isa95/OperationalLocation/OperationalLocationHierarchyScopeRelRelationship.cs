
namespace MOM.Domain.Common.Relationship.isa95.OperationalLocation
{
    /// <summary>
    /// 
    /// </summary>
    public class OperationalLocationHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation ,Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<OperationalLocationHierarchyScopeRelRelationship>
    {
        /// <inheritdoc/>
        public override string Name { get; set; } = "hierarchyScopeRel";

        /// <inheritdoc/>
        public OperationalLocationHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation source, Domain.isa95.CommonObjectModels.HierarchyScope target) : base(source, target)
        {
        }
        /// <inheritdoc/>
        public OperationalLocationHierarchyScopeRelRelationship(Guid sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }
        /// <inheritdoc/>
        public OperationalLocationHierarchyScopeRelRelationship(Guid sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }
        /// <inheritdoc/>
        public OperationalLocationHierarchyScopeRelRelationship(Guid sourceId, Domain.isa95.CommonObjectModels.HierarchyScope target, int depth) : base(sourceId, target, depth)
        {
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationalLocationHierarchyScopeRelRelationship);
        }

        /// <inheritdoc/>
        public bool Equals(OperationalLocationHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        /// <inheritdoc/>
        public static bool operator ==(OperationalLocationHierarchyScopeRelRelationship? left, OperationalLocationHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<OperationalLocationHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(OperationalLocationHierarchyScopeRelRelationship? left, OperationalLocationHierarchyScopeRelRelationship? right)
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
            return Equals(other as OperationalLocationHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
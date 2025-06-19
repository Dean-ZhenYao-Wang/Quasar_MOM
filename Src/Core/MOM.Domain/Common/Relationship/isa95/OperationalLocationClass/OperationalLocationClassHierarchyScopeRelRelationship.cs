
namespace MOM.Domain.Common.Relationship.isa95.OperationalLocationClass
{
    /// <summary>
    /// 
    /// </summary>
    public class OperationalLocationClassHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClass,Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<OperationalLocationClassHierarchyScopeRelRelationship>
    {
        /// <inheritdoc/>
        public OperationalLocationClassHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }
        /// <inheritdoc/>
        public OperationalLocationClassHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClass source, Domain.isa95.CommonObjectModels.HierarchyScope target) : base(source, target)
        {
        }
        /// <inheritdoc/>
        public OperationalLocationClassHierarchyScopeRelRelationship(Guid sourceId, Guid targetId) : base(sourceId, targetId)
        {
        }
        /// <inheritdoc/>
        public OperationalLocationClassHierarchyScopeRelRelationship(Guid sourceId, Guid targetId, int depth) : base(sourceId, targetId, depth)
        {
        }
        /// <inheritdoc/>
        public OperationalLocationClassHierarchyScopeRelRelationship(Guid sourceId, Domain.isa95.CommonObjectModels.HierarchyScope target, int depth) : base(sourceId, target, depth)
        {
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationalLocationClassHierarchyScopeRelRelationship);
        }

        /// <inheritdoc/>
        public bool Equals(OperationalLocationClassHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        /// <inheritdoc/>
        public static bool operator ==(OperationalLocationClassHierarchyScopeRelRelationship? left, OperationalLocationClassHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<OperationalLocationClassHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(OperationalLocationClassHierarchyScopeRelRelationship? left, OperationalLocationClassHierarchyScopeRelRelationship? right)
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
            return Equals(other as OperationalLocationClassHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
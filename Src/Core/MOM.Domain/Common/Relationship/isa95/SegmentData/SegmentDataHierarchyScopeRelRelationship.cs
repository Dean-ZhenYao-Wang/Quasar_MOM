namespace MOM.Domain.Common.Relationship.isa95.SegmentData
{
    public class SegmentDataHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<SegmentDataHierarchyScopeRelRelationship>
    {
        public SegmentDataHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public SegmentDataHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.SegmentData source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public SegmentDataHierarchyScopeRelRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentDataHierarchyScopeRelRelationship);
        }

        public bool Equals(SegmentDataHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SegmentDataHierarchyScopeRelRelationship? left, SegmentDataHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<SegmentDataHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentDataHierarchyScopeRelRelationship? left, SegmentDataHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SegmentDataHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.SegmentResponse
{
    public class SegmentResponseHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<SegmentResponseHierarchyScopeRelRelationship>
    {
        public SegmentResponseHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public SegmentResponseHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.SegmentResponse source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public SegmentResponseHierarchyScopeRelRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentResponseHierarchyScopeRelRelationship);
        }

        public bool Equals(SegmentResponseHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SegmentResponseHierarchyScopeRelRelationship? left, SegmentResponseHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<SegmentResponseHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentResponseHierarchyScopeRelRelationship? left, SegmentResponseHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SegmentResponseHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
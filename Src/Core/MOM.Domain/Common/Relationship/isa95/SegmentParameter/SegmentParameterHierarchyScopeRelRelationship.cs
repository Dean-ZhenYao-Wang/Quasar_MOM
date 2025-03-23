namespace MOM.Domain.Common.Relationship.isa95.SegmentParameter
{
    public class SegmentParameterHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<SegmentParameterHierarchyScopeRelRelationship>
    {
        public SegmentParameterHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public SegmentParameterHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentParameter source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public SegmentParameterHierarchyScopeRelRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentParameterHierarchyScopeRelRelationship);
        }

        public bool Equals(SegmentParameterHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SegmentParameterHierarchyScopeRelRelationship? left, SegmentParameterHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<SegmentParameterHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentParameterHierarchyScopeRelRelationship? left, SegmentParameterHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SegmentParameterHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
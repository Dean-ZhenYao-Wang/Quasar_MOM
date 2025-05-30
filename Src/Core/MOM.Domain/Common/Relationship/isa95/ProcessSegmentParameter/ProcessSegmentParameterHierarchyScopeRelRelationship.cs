namespace MOM.Domain.Common.Relationship.isa95.ProcessSegmentParameter
{
    public class ProcessSegmentParameterHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<ProcessSegmentParameterHierarchyScopeRelRelationship>
    {
        public ProcessSegmentParameterHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public ProcessSegmentParameterHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegmentParameter source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ProcessSegmentParameterHierarchyScopeRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ProcessSegmentParameterHierarchyScopeRelRelationship);
        }

        public bool Equals(ProcessSegmentParameterHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ProcessSegmentParameterHierarchyScopeRelRelationship? left, ProcessSegmentParameterHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<ProcessSegmentParameterHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ProcessSegmentParameterHierarchyScopeRelRelationship? left, ProcessSegmentParameterHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ProcessSegmentParameterHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
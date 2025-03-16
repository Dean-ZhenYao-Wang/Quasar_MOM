namespace MOM.Domain.Common.Relationship.isa95.ProcessSegmentCapability
{
    public class ProcessSegmentCapabilityHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<ProcessSegmentCapabilityHierarchyScopeRelRelationship>
    {
        public ProcessSegmentCapabilityHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public ProcessSegmentCapabilityHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.ProcessSegmentCapability source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ProcessSegmentCapabilityHierarchyScopeRelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ProcessSegmentCapabilityHierarchyScopeRelRelationship);
        }

        public bool Equals(ProcessSegmentCapabilityHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ProcessSegmentCapabilityHierarchyScopeRelRelationship? left, ProcessSegmentCapabilityHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<ProcessSegmentCapabilityHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ProcessSegmentCapabilityHierarchyScopeRelRelationship? left, ProcessSegmentCapabilityHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ProcessSegmentCapabilityHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
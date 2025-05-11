namespace MOM.Domain.Common.Relationship.isa95.OperationsSegment
{
    public class OperationsSegmentHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<OperationsSegmentHierarchyScopeRelRelationship>
    {
        public OperationsSegmentHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public OperationsSegmentHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsSegmentHierarchyScopeRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsSegmentHierarchyScopeRelRelationship);
        }

        public bool Equals(OperationsSegmentHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsSegmentHierarchyScopeRelRelationship? left, OperationsSegmentHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<OperationsSegmentHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsSegmentHierarchyScopeRelRelationship? left, OperationsSegmentHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsSegmentHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
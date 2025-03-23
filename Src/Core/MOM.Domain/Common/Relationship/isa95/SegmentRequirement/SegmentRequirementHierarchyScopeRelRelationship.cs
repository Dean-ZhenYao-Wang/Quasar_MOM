namespace MOM.Domain.Common.Relationship.isa95.SegmentRequirement
{
    public class SegmentRequirementHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<SegmentRequirementHierarchyScopeRelRelationship>
    {
        public SegmentRequirementHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public SegmentRequirementHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.SegmentRequirement source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public SegmentRequirementHierarchyScopeRelRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentRequirementHierarchyScopeRelRelationship);
        }

        public bool Equals(SegmentRequirementHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SegmentRequirementHierarchyScopeRelRelationship? left, SegmentRequirementHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<SegmentRequirementHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentRequirementHierarchyScopeRelRelationship? left, SegmentRequirementHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SegmentRequirementHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
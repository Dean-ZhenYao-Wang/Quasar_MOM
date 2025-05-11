namespace MOM.Domain.Common.Relationship.isa95.WorkRecord
{
    public class WorkRecordHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<WorkRecordHierarchyScopeRelRelationship>
    {
        public WorkRecordHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public WorkRecordHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part4.WorkRecord.WorkRecord source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkRecordHierarchyScopeRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkRecordHierarchyScopeRelRelationship);
        }

        public bool Equals(WorkRecordHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkRecordHierarchyScopeRelRelationship? left, WorkRecordHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<WorkRecordHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkRecordHierarchyScopeRelRelationship? left, WorkRecordHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkRecordHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
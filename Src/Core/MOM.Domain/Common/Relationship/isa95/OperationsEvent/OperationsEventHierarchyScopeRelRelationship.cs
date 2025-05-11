namespace MOM.Domain.Common.Relationship.isa95.OperationsEvent
{
    public class OperationsEventHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<OperationsEventHierarchyScopeRelRelationship>
    {
        public OperationsEventHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public OperationsEventHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEvent source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsEventHierarchyScopeRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsEventHierarchyScopeRelRelationship);
        }

        public bool Equals(OperationsEventHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsEventHierarchyScopeRelRelationship? left, OperationsEventHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<OperationsEventHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsEventHierarchyScopeRelRelationship? left, OperationsEventHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsEventHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.OperationsResponse
{
    public class OperationsResponseHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<OperationsResponseHierarchyScopeRelRelationship>
    {
        public OperationsResponseHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public OperationsResponseHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.OperationsResponse source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsResponseHierarchyScopeRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsResponseHierarchyScopeRelRelationship);
        }

        public bool Equals(OperationsResponseHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsResponseHierarchyScopeRelRelationship? left, OperationsResponseHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<OperationsResponseHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsResponseHierarchyScopeRelRelationship? left, OperationsResponseHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsResponseHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
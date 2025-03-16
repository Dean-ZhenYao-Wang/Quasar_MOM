namespace MOM.Domain.Common.Relationship.isa95.OperationsCapability
{
    public class OperationsCapabilityHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<OperationsCapabilityHierarchyScopeRelRelationship>
    {
        public OperationsCapabilityHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public OperationsCapabilityHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.OperationsCapability source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsCapabilityHierarchyScopeRelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsCapabilityHierarchyScopeRelRelationship);
        }

        public bool Equals(OperationsCapabilityHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsCapabilityHierarchyScopeRelRelationship? left, OperationsCapabilityHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<OperationsCapabilityHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsCapabilityHierarchyScopeRelRelationship? left, OperationsCapabilityHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsCapabilityHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
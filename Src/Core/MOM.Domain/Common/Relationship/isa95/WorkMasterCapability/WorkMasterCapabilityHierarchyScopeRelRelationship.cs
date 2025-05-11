namespace MOM.Domain.Common.Relationship.isa95.WorkMasterCapability
{
    public class WorkMasterCapabilityHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<WorkMasterCapabilityHierarchyScopeRelRelationship>
    {
        public WorkMasterCapabilityHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public WorkMasterCapabilityHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part4.WorkCapability.WorkMasterCapability source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public WorkMasterCapabilityHierarchyScopeRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkMasterCapabilityHierarchyScopeRelRelationship);
        }

        public bool Equals(WorkMasterCapabilityHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WorkMasterCapabilityHierarchyScopeRelRelationship? left, WorkMasterCapabilityHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<WorkMasterCapabilityHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkMasterCapabilityHierarchyScopeRelRelationship? left, WorkMasterCapabilityHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WorkMasterCapabilityHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
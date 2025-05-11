namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetRequirement
{
    public class PhysicalAssetRequirementHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<PhysicalAssetRequirementHierarchyScopeRelRelationship>
    {
        public PhysicalAssetRequirementHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public PhysicalAssetRequirementHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PhysicalAssetRequirement source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PhysicalAssetRequirementHierarchyScopeRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetRequirementHierarchyScopeRelRelationship);
        }

        public bool Equals(PhysicalAssetRequirementHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PhysicalAssetRequirementHierarchyScopeRelRelationship? left, PhysicalAssetRequirementHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<PhysicalAssetRequirementHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetRequirementHierarchyScopeRelRelationship? left, PhysicalAssetRequirementHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PhysicalAssetRequirementHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
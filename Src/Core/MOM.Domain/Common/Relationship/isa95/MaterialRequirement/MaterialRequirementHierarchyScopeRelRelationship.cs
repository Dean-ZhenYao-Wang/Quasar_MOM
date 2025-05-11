namespace MOM.Domain.Common.Relationship.isa95.MaterialRequirement
{
    public class MaterialRequirementHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<MaterialRequirementHierarchyScopeRelRelationship>
    {
        public MaterialRequirementHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public MaterialRequirementHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirement source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public MaterialRequirementHierarchyScopeRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialRequirementHierarchyScopeRelRelationship);
        }

        public bool Equals(MaterialRequirementHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MaterialRequirementHierarchyScopeRelRelationship? left, MaterialRequirementHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<MaterialRequirementHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialRequirementHierarchyScopeRelRelationship? left, MaterialRequirementHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MaterialRequirementHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
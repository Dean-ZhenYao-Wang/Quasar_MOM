namespace MOM.Domain.Common.Relationship.isa95.PersonnelRequirement
{
    public class PersonnelRequirementHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<PersonnelRequirementHierarchyScopeRelRelationship>
    {
        public PersonnelRequirementHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public PersonnelRequirementHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PersonnelRequirement source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelRequirementHierarchyScopeRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelRequirementHierarchyScopeRelRelationship);
        }

        public bool Equals(PersonnelRequirementHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelRequirementHierarchyScopeRelRelationship? left, PersonnelRequirementHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<PersonnelRequirementHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelRequirementHierarchyScopeRelRelationship? left, PersonnelRequirementHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelRequirementHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
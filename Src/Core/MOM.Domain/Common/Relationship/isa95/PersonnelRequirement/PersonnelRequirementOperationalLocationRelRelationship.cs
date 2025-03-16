namespace MOM.Domain.Common.Relationship.isa95.PersonnelRequirement
{
    public class PersonnelRequirementOperationalLocationRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>, IEquatable<PersonnelRequirementOperationalLocationRelRelationship>
    {
        public PersonnelRequirementOperationalLocationRelRelationship()
        {
            Name = "operationalLocationRel";
        }

        public PersonnelRequirementOperationalLocationRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PersonnelRequirement source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelRequirementOperationalLocationRelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelRequirementOperationalLocationRelRelationship);
        }

        public bool Equals(PersonnelRequirementOperationalLocationRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelRequirementOperationalLocationRelRelationship? left, PersonnelRequirementOperationalLocationRelRelationship? right)
        {
            return EqualityComparer<PersonnelRequirementOperationalLocationRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelRequirementOperationalLocationRelRelationship? left, PersonnelRequirementOperationalLocationRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelRequirementOperationalLocationRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
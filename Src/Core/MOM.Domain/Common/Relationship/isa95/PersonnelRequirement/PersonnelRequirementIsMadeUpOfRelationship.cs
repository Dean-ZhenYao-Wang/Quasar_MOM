namespace MOM.Domain.Common.Relationship.isa95.PersonnelRequirement
{
    public class PersonnelRequirementIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PersonnelRequirement>, IEquatable<PersonnelRequirementIsMadeUpOfRelationship>
    {
        public PersonnelRequirementIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public PersonnelRequirementIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PersonnelRequirement source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PersonnelRequirement target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelRequirementIsMadeUpOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelRequirementIsMadeUpOfRelationship);
        }

        public bool Equals(PersonnelRequirementIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelRequirementIsMadeUpOfRelationship? left, PersonnelRequirementIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<PersonnelRequirementIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelRequirementIsMadeUpOfRelationship? left, PersonnelRequirementIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelRequirementIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
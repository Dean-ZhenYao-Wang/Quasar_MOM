namespace MOM.Domain.Common.Relationship.isa95.PersonnelRequirement
{
    public class PersonnelRequirementCorrespondsToPersonRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.Person>, IEquatable<PersonnelRequirementCorrespondsToPersonRelationship>
    {
        public PersonnelRequirementCorrespondsToPersonRelationship()
        {
            Name = "correspondsToPerson";
        }

        public PersonnelRequirementCorrespondsToPersonRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PersonnelRequirement source, Domain.isa95.CommonObjectModels.Part2.Personnel.Person target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelRequirementCorrespondsToPersonRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelRequirementCorrespondsToPersonRelationship);
        }

        public bool Equals(PersonnelRequirementCorrespondsToPersonRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelRequirementCorrespondsToPersonRelationship? left, PersonnelRequirementCorrespondsToPersonRelationship? right)
        {
            return EqualityComparer<PersonnelRequirementCorrespondsToPersonRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelRequirementCorrespondsToPersonRelationship? left, PersonnelRequirementCorrespondsToPersonRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelRequirementCorrespondsToPersonRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
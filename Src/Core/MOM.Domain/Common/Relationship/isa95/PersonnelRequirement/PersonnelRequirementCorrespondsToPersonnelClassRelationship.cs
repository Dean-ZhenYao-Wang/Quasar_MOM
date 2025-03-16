namespace MOM.Domain.Common.Relationship.isa95.PersonnelRequirement
{
    public class PersonnelRequirementCorrespondsToPersonnelClassRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass>, IEquatable<PersonnelRequirementCorrespondsToPersonnelClassRelationship>
    {
        public PersonnelRequirementCorrespondsToPersonnelClassRelationship()
        {
            Name = "correspondsToPersonnelClass";
        }

        public PersonnelRequirementCorrespondsToPersonnelClassRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PersonnelRequirement source, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelRequirementCorrespondsToPersonnelClassRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelRequirementCorrespondsToPersonnelClassRelationship);
        }

        public bool Equals(PersonnelRequirementCorrespondsToPersonnelClassRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelRequirementCorrespondsToPersonnelClassRelationship? left, PersonnelRequirementCorrespondsToPersonnelClassRelationship? right)
        {
            return EqualityComparer<PersonnelRequirementCorrespondsToPersonnelClassRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelRequirementCorrespondsToPersonnelClassRelationship? left, PersonnelRequirementCorrespondsToPersonnelClassRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelRequirementCorrespondsToPersonnelClassRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.PersonnelRequirementProperty
{
    public class PersonnelRequirementPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PersonnelRequirementProperty>, IEquatable<PersonnelRequirementPropertyContainsRelationship>
    {
        public PersonnelRequirementPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public PersonnelRequirementPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PersonnelRequirementProperty source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PersonnelRequirementProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelRequirementPropertyContainsRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelRequirementPropertyContainsRelationship);
        }

        public bool Equals(PersonnelRequirementPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelRequirementPropertyContainsRelationship? left, PersonnelRequirementPropertyContainsRelationship? right)
        {
            return EqualityComparer<PersonnelRequirementPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelRequirementPropertyContainsRelationship? left, PersonnelRequirementPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelRequirementPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
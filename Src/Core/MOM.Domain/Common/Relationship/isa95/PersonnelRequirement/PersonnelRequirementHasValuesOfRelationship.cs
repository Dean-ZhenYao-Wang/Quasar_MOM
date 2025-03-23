namespace MOM.Domain.Common.Relationship.isa95.PersonnelRequirement
{
    public class PersonnelRequirementHasValuesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PersonnelRequirementProperty>, IEquatable<PersonnelRequirementHasValuesOfRelationship>
    {
        public PersonnelRequirementHasValuesOfRelationship()
        {
            Name = "hasValuesOf";
        }

        public PersonnelRequirementHasValuesOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PersonnelRequirement source, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PersonnelRequirementProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelRequirementHasValuesOfRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelRequirementHasValuesOfRelationship);
        }

        public bool Equals(PersonnelRequirementHasValuesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelRequirementHasValuesOfRelationship? left, PersonnelRequirementHasValuesOfRelationship? right)
        {
            return EqualityComparer<PersonnelRequirementHasValuesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelRequirementHasValuesOfRelationship? left, PersonnelRequirementHasValuesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelRequirementHasValuesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.PersonnelRequirementProperty
{
    public class PersonnelRequirementPropertyMapsToPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.PersonProperty>, IEquatable<PersonnelRequirementPropertyMapsToPropertyRelationship>
    {
        public PersonnelRequirementPropertyMapsToPropertyRelationship()
        {
            Name = "mapsToProperty";
        }

        public PersonnelRequirementPropertyMapsToPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PersonnelRequirementProperty source, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelRequirementPropertyMapsToPropertyRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelRequirementPropertyMapsToPropertyRelationship);
        }

        public bool Equals(PersonnelRequirementPropertyMapsToPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelRequirementPropertyMapsToPropertyRelationship? left, PersonnelRequirementPropertyMapsToPropertyRelationship? right)
        {
            return EqualityComparer<PersonnelRequirementPropertyMapsToPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelRequirementPropertyMapsToPropertyRelationship? left, PersonnelRequirementPropertyMapsToPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelRequirementPropertyMapsToPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
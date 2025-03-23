namespace MOM.Domain.Common.Relationship.isa95.PersonnelRequirementProperty
{
    public class PersonnelRequirementPropertyMapsToClassPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClassProperty>, IEquatable<PersonnelRequirementPropertyMapsToClassPropertyRelationship>
    {
        public PersonnelRequirementPropertyMapsToClassPropertyRelationship()
        {
            Name = "mapsToClassProperty";
        }

        public PersonnelRequirementPropertyMapsToClassPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PersonnelRequirementProperty source, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelRequirementPropertyMapsToClassPropertyRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelRequirementPropertyMapsToClassPropertyRelationship);
        }

        public bool Equals(PersonnelRequirementPropertyMapsToClassPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelRequirementPropertyMapsToClassPropertyRelationship? left, PersonnelRequirementPropertyMapsToClassPropertyRelationship? right)
        {
            return EqualityComparer<PersonnelRequirementPropertyMapsToClassPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelRequirementPropertyMapsToClassPropertyRelationship? left, PersonnelRequirementPropertyMapsToClassPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelRequirementPropertyMapsToClassPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
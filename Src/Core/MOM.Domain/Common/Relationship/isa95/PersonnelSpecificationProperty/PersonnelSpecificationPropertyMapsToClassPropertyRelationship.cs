namespace MOM.Domain.Common.Relationship.isa95.PersonnelSpecificationProperty
{
    public class PersonnelSpecificationPropertyMapsToClassPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClassProperty>, IEquatable<PersonnelSpecificationPropertyMapsToClassPropertyRelationship>
    {
        public PersonnelSpecificationPropertyMapsToClassPropertyRelationship()
        {
            Name = "mapsToClassProperty";
        }

        public PersonnelSpecificationPropertyMapsToClassPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PersonnelSpecificationProperty source, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelSpecificationPropertyMapsToClassPropertyRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelSpecificationPropertyMapsToClassPropertyRelationship);
        }

        public bool Equals(PersonnelSpecificationPropertyMapsToClassPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelSpecificationPropertyMapsToClassPropertyRelationship? left, PersonnelSpecificationPropertyMapsToClassPropertyRelationship? right)
        {
            return EqualityComparer<PersonnelSpecificationPropertyMapsToClassPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelSpecificationPropertyMapsToClassPropertyRelationship? left, PersonnelSpecificationPropertyMapsToClassPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelSpecificationPropertyMapsToClassPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
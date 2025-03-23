namespace MOM.Domain.Common.Relationship.isa95.PersonnelSpecificationProperty
{
    public class PersonnelSpecificationPropertyMapsToPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.PersonProperty>, IEquatable<PersonnelSpecificationPropertyMapsToPropertyRelationship>
    {
        public PersonnelSpecificationPropertyMapsToPropertyRelationship()
        {
            Name = "mapsToProperty";
        }

        public PersonnelSpecificationPropertyMapsToPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PersonnelSpecificationProperty source, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelSpecificationPropertyMapsToPropertyRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelSpecificationPropertyMapsToPropertyRelationship);
        }

        public bool Equals(PersonnelSpecificationPropertyMapsToPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelSpecificationPropertyMapsToPropertyRelationship? left, PersonnelSpecificationPropertyMapsToPropertyRelationship? right)
        {
            return EqualityComparer<PersonnelSpecificationPropertyMapsToPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelSpecificationPropertyMapsToPropertyRelationship? left, PersonnelSpecificationPropertyMapsToPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelSpecificationPropertyMapsToPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
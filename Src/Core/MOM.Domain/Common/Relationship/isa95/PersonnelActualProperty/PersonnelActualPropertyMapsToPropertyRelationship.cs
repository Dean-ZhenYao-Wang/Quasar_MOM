namespace MOM.Domain.Common.Relationship.isa95.PersonnelActualProperty
{
    public class PersonnelActualPropertyMapsToPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.PersonProperty>, IEquatable<PersonnelActualPropertyMapsToPropertyRelationship>
    {
        public PersonnelActualPropertyMapsToPropertyRelationship()
        {
            Name = "mapsToProperty";
        }

        public PersonnelActualPropertyMapsToPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PersonnelActualProperty source, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelActualPropertyMapsToPropertyRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelActualPropertyMapsToPropertyRelationship);
        }

        public bool Equals(PersonnelActualPropertyMapsToPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelActualPropertyMapsToPropertyRelationship? left, PersonnelActualPropertyMapsToPropertyRelationship? right)
        {
            return EqualityComparer<PersonnelActualPropertyMapsToPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelActualPropertyMapsToPropertyRelationship? left, PersonnelActualPropertyMapsToPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelActualPropertyMapsToPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
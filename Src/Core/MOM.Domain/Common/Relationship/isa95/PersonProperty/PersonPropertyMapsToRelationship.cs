namespace MOM.Domain.Common.Relationship.isa95.PersonProperty
{
    public partial class PersonPropertyMapsToRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClassProperty>, IEquatable<PersonPropertyMapsToRelationship>
    {
        public PersonPropertyMapsToRelationship()
        {
            Name = "mapsTo";
        }

        public PersonPropertyMapsToRelationship(Domain.isa95.CommonObjectModels.Part2.Personnel.PersonProperty source, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonPropertyMapsToRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonPropertyMapsToRelationship);
        }

        public bool Equals(PersonPropertyMapsToRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonPropertyMapsToRelationship? left, PersonPropertyMapsToRelationship? right)
        {
            return EqualityComparer<PersonPropertyMapsToRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonPropertyMapsToRelationship? left, PersonPropertyMapsToRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonPropertyMapsToRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.Person
{
    public partial class PersonHasValuesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.PersonProperty>, IEquatable<PersonHasValuesOfRelationship>
    {
        public PersonHasValuesOfRelationship()
        {
            Name = "hasValuesOf";
        }

        public PersonHasValuesOfRelationship(Domain.isa95.CommonObjectModels.Part2.Personnel.Person source, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonHasValuesOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonHasValuesOfRelationship);
        }

        public bool Equals(PersonHasValuesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonHasValuesOfRelationship? left, PersonHasValuesOfRelationship? right)
        {
            return EqualityComparer<PersonHasValuesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonHasValuesOfRelationship? left, PersonHasValuesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonHasValuesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
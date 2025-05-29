namespace MOM.Domain.Common.Relationship.isa95.Person
{
    public class PersonOperationalLocationRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.Person ,Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>, IEquatable<PersonOperationalLocationRelRelationship>
    {
        public PersonOperationalLocationRelRelationship():base()
        {
            Name = "operationalLocationRel";
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonOperationalLocationRelRelationship);
        }

        public bool Equals(PersonOperationalLocationRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonOperationalLocationRelRelationship? left, PersonOperationalLocationRelRelationship? right)
        {
            return EqualityComparer<PersonOperationalLocationRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonOperationalLocationRelRelationship? left, PersonOperationalLocationRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonOperationalLocationRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
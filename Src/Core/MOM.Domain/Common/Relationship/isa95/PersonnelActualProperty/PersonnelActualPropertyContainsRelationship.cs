namespace MOM.Domain.Common.Relationship.isa95.PersonnelActualProperty
{
    public class PersonnelActualPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PersonnelActualProperty>, IEquatable<PersonnelActualPropertyContainsRelationship>
    {
        public PersonnelActualPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public PersonnelActualPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PersonnelActualProperty source, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PersonnelActualProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelActualPropertyContainsRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelActualPropertyContainsRelationship);
        }

        public bool Equals(PersonnelActualPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelActualPropertyContainsRelationship? left, PersonnelActualPropertyContainsRelationship? right)
        {
            return EqualityComparer<PersonnelActualPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelActualPropertyContainsRelationship? left, PersonnelActualPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelActualPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
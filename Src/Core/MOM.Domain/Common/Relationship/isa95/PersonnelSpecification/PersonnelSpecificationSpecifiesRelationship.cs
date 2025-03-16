namespace MOM.Domain.Common.Relationship.isa95.PersonnelSpecification
{
    public class PersonnelSpecificationSpecifiesRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification>, IEquatable<PersonnelSpecificationSpecifiesRelationship>
    {
        public PersonnelSpecificationSpecifiesRelationship()
        {
            Name = "specifies";
        }

        public PersonnelSpecificationSpecifiesRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PersonnelSpecification source, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelSpecificationSpecifiesRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelSpecificationSpecifiesRelationship);
        }

        public bool Equals(PersonnelSpecificationSpecifiesRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelSpecificationSpecifiesRelationship? left, PersonnelSpecificationSpecifiesRelationship? right)
        {
            return EqualityComparer<PersonnelSpecificationSpecifiesRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelSpecificationSpecifiesRelationship? left, PersonnelSpecificationSpecifiesRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelSpecificationSpecifiesRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
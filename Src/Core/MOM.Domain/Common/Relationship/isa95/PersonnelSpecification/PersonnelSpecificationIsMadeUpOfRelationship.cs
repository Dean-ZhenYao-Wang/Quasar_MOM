namespace MOM.Domain.Common.Relationship.isa95.PersonnelSpecification
{
    public class PersonnelSpecificationIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PersonnelSpecification>, IEquatable<PersonnelSpecificationIsMadeUpOfRelationship>
    {
        public PersonnelSpecificationIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public PersonnelSpecificationIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PersonnelSpecification source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PersonnelSpecification target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelSpecificationIsMadeUpOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelSpecificationIsMadeUpOfRelationship);
        }

        public bool Equals(PersonnelSpecificationIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelSpecificationIsMadeUpOfRelationship? left, PersonnelSpecificationIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<PersonnelSpecificationIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelSpecificationIsMadeUpOfRelationship? left, PersonnelSpecificationIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelSpecificationIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
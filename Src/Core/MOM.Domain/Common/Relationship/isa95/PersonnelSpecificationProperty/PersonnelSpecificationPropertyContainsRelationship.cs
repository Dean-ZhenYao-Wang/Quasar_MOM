namespace MOM.Domain.Common.Relationship.isa95.PersonnelSpecificationProperty
{
    public class PersonnelSpecificationPropertyContainsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PersonnelSpecificationProperty>, IEquatable<PersonnelSpecificationPropertyContainsRelationship>
    {
        public PersonnelSpecificationPropertyContainsRelationship()
        {
            Name = "contains";
        }

        public PersonnelSpecificationPropertyContainsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PersonnelSpecificationProperty source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PersonnelSpecificationProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelSpecificationPropertyContainsRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelSpecificationPropertyContainsRelationship);
        }

        public bool Equals(PersonnelSpecificationPropertyContainsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelSpecificationPropertyContainsRelationship? left, PersonnelSpecificationPropertyContainsRelationship? right)
        {
            return EqualityComparer<PersonnelSpecificationPropertyContainsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelSpecificationPropertyContainsRelationship? left, PersonnelSpecificationPropertyContainsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelSpecificationPropertyContainsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
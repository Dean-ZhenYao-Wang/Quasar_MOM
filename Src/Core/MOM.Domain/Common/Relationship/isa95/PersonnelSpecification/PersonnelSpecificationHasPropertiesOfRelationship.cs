namespace MOM.Domain.Common.Relationship.isa95.PersonnelSpecification
{
    public class PersonnelSpecificationHasPropertiesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PersonnelSpecificationProperty>, IEquatable<PersonnelSpecificationHasPropertiesOfRelationship>
    {
        public PersonnelSpecificationHasPropertiesOfRelationship()
        {
            Name = "hasPropertiesOf";
        }

        public PersonnelSpecificationHasPropertiesOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PersonnelSpecification source, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PersonnelSpecificationProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelSpecificationHasPropertiesOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelSpecificationHasPropertiesOfRelationship);
        }

        public bool Equals(PersonnelSpecificationHasPropertiesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelSpecificationHasPropertiesOfRelationship? left, PersonnelSpecificationHasPropertiesOfRelationship? right)
        {
            return EqualityComparer<PersonnelSpecificationHasPropertiesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelSpecificationHasPropertiesOfRelationship? left, PersonnelSpecificationHasPropertiesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelSpecificationHasPropertiesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
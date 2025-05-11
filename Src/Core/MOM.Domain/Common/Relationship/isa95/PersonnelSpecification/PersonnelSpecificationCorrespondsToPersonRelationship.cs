namespace MOM.Domain.Common.Relationship.isa95.PersonnelSpecification
{
    public class PersonnelSpecificationCorrespondsToPersonRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.Person>, IEquatable<PersonnelSpecificationCorrespondsToPersonRelationship>
    {
        public PersonnelSpecificationCorrespondsToPersonRelationship()
        {
            Name = "correspondsToPerson";
        }

        public PersonnelSpecificationCorrespondsToPersonRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PersonnelSpecification source, Domain.isa95.CommonObjectModels.Part2.Personnel.Person target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelSpecificationCorrespondsToPersonRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelSpecificationCorrespondsToPersonRelationship);
        }

        public bool Equals(PersonnelSpecificationCorrespondsToPersonRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelSpecificationCorrespondsToPersonRelationship? left, PersonnelSpecificationCorrespondsToPersonRelationship? right)
        {
            return EqualityComparer<PersonnelSpecificationCorrespondsToPersonRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelSpecificationCorrespondsToPersonRelationship? left, PersonnelSpecificationCorrespondsToPersonRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelSpecificationCorrespondsToPersonRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
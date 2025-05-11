namespace MOM.Domain.Common.Relationship.isa95.PersonnelSpecification
{
    public class PersonnelSpecificationCorrespondsToPersonnelClassRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass>, IEquatable<PersonnelSpecificationCorrespondsToPersonnelClassRelationship>
    {
        public PersonnelSpecificationCorrespondsToPersonnelClassRelationship()
        {
            Name = "correspondsToPersonnelClass";
        }

        public PersonnelSpecificationCorrespondsToPersonnelClassRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PersonnelSpecification source, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelSpecificationCorrespondsToPersonnelClassRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelSpecificationCorrespondsToPersonnelClassRelationship);
        }

        public bool Equals(PersonnelSpecificationCorrespondsToPersonnelClassRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelSpecificationCorrespondsToPersonnelClassRelationship? left, PersonnelSpecificationCorrespondsToPersonnelClassRelationship? right)
        {
            return EqualityComparer<PersonnelSpecificationCorrespondsToPersonnelClassRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelSpecificationCorrespondsToPersonnelClassRelationship? left, PersonnelSpecificationCorrespondsToPersonnelClassRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelSpecificationCorrespondsToPersonnelClassRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
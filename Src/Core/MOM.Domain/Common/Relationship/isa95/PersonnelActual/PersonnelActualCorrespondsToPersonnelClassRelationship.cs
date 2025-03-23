namespace MOM.Domain.Common.Relationship.isa95.PersonnelActual
{
    public class PersonnelActualCorrespondsToPersonnelClassRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass>, IEquatable<PersonnelActualCorrespondsToPersonnelClassRelationship>
    {
        public PersonnelActualCorrespondsToPersonnelClassRelationship()
        {
            Name = "correspondsToPersonnelClass";
        }

        public PersonnelActualCorrespondsToPersonnelClassRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PersonnelActual source, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelActualCorrespondsToPersonnelClassRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelActualCorrespondsToPersonnelClassRelationship);
        }

        public bool Equals(PersonnelActualCorrespondsToPersonnelClassRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelActualCorrespondsToPersonnelClassRelationship? left, PersonnelActualCorrespondsToPersonnelClassRelationship? right)
        {
            return EqualityComparer<PersonnelActualCorrespondsToPersonnelClassRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelActualCorrespondsToPersonnelClassRelationship? left, PersonnelActualCorrespondsToPersonnelClassRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelActualCorrespondsToPersonnelClassRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.PersonnelActual
{
    public class PersonnelActualCorrespondsToPersonRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.Person>, IEquatable<PersonnelActualCorrespondsToPersonRelationship>
    {
        public PersonnelActualCorrespondsToPersonRelationship()
        {
            Name = "correspondsToPerson";
        }

        public PersonnelActualCorrespondsToPersonRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PersonnelActual source, Domain.isa95.CommonObjectModels.Part2.Personnel.Person target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelActualCorrespondsToPersonRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelActualCorrespondsToPersonRelationship);
        }

        public bool Equals(PersonnelActualCorrespondsToPersonRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelActualCorrespondsToPersonRelationship? left, PersonnelActualCorrespondsToPersonRelationship? right)
        {
            return EqualityComparer<PersonnelActualCorrespondsToPersonRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelActualCorrespondsToPersonRelationship? left, PersonnelActualCorrespondsToPersonRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelActualCorrespondsToPersonRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
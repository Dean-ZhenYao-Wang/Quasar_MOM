namespace MOM.Domain.Common.Relationship.isa95.PersonnelCapability
{
    public class PersonnelCapabilityCorrespondsToPersonnelClassRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass>, IEquatable<PersonnelCapabilityCorrespondsToPersonnelClassRelationship>
    {
        public PersonnelCapabilityCorrespondsToPersonnelClassRelationship()
        {
            Name = "correspondsToPersonnelClass";
        }

        public PersonnelCapabilityCorrespondsToPersonnelClassRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PersonnelCapability source, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelCapabilityCorrespondsToPersonnelClassRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelCapabilityCorrespondsToPersonnelClassRelationship);
        }

        public bool Equals(PersonnelCapabilityCorrespondsToPersonnelClassRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelCapabilityCorrespondsToPersonnelClassRelationship? left, PersonnelCapabilityCorrespondsToPersonnelClassRelationship? right)
        {
            return EqualityComparer<PersonnelCapabilityCorrespondsToPersonnelClassRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelCapabilityCorrespondsToPersonnelClassRelationship? left, PersonnelCapabilityCorrespondsToPersonnelClassRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelCapabilityCorrespondsToPersonnelClassRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.PersonnelCapability
{
    public class PersonnelCapabilityCorrespondsToPersonRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.Person>, IEquatable<PersonnelCapabilityCorrespondsToPersonRelationship>
    {
        public PersonnelCapabilityCorrespondsToPersonRelationship()
        {
            Name = "correspondsToPerson";
        }

        public PersonnelCapabilityCorrespondsToPersonRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PersonnelCapability source, Domain.isa95.CommonObjectModels.Part2.Personnel.Person target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelCapabilityCorrespondsToPersonRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelCapabilityCorrespondsToPersonRelationship);
        }

        public bool Equals(PersonnelCapabilityCorrespondsToPersonRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelCapabilityCorrespondsToPersonRelationship? left, PersonnelCapabilityCorrespondsToPersonRelationship? right)
        {
            return EqualityComparer<PersonnelCapabilityCorrespondsToPersonRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelCapabilityCorrespondsToPersonRelationship? left, PersonnelCapabilityCorrespondsToPersonRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelCapabilityCorrespondsToPersonRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
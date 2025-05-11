namespace MOM.Domain.Common.Relationship.isa95.PersonnelCapability
{
    public class PersonnelCapabilityIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PersonnelCapability>, IEquatable<PersonnelCapabilityIsMadeUpOfRelationship>
    {
        public PersonnelCapabilityIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public PersonnelCapabilityIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PersonnelCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PersonnelCapability target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelCapabilityIsMadeUpOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelCapabilityIsMadeUpOfRelationship);
        }

        public bool Equals(PersonnelCapabilityIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelCapabilityIsMadeUpOfRelationship? left, PersonnelCapabilityIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<PersonnelCapabilityIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelCapabilityIsMadeUpOfRelationship? left, PersonnelCapabilityIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelCapabilityIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
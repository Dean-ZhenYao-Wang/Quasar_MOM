namespace MOM.Domain.Common.Relationship.isa95.PersonnelCapability
{
    public class PersonnelCapabilityOperationalLocationRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>, IEquatable<PersonnelCapabilityOperationalLocationRelRelationship>
    {
        public PersonnelCapabilityOperationalLocationRelRelationship()
        {
            Name = "operationalLocationRel";
        }

        public PersonnelCapabilityOperationalLocationRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PersonnelCapability source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelCapabilityOperationalLocationRelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelCapabilityOperationalLocationRelRelationship);
        }

        public bool Equals(PersonnelCapabilityOperationalLocationRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelCapabilityOperationalLocationRelRelationship? left, PersonnelCapabilityOperationalLocationRelRelationship? right)
        {
            return EqualityComparer<PersonnelCapabilityOperationalLocationRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelCapabilityOperationalLocationRelRelationship? left, PersonnelCapabilityOperationalLocationRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelCapabilityOperationalLocationRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
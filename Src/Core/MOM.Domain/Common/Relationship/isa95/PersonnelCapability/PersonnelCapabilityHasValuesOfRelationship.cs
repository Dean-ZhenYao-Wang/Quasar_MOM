namespace MOM.Domain.Common.Relationship.isa95.PersonnelCapability
{
    public class PersonnelCapabilityHasValuesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PersonnelCapabilityProperty>, IEquatable<PersonnelCapabilityHasValuesOfRelationship>
    {
        public PersonnelCapabilityHasValuesOfRelationship()
        {
            Name = "hasValuesOf";
        }

        public PersonnelCapabilityHasValuesOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PersonnelCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PersonnelCapabilityProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelCapabilityHasValuesOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelCapabilityHasValuesOfRelationship);
        }

        public bool Equals(PersonnelCapabilityHasValuesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelCapabilityHasValuesOfRelationship? left, PersonnelCapabilityHasValuesOfRelationship? right)
        {
            return EqualityComparer<PersonnelCapabilityHasValuesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelCapabilityHasValuesOfRelationship? left, PersonnelCapabilityHasValuesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelCapabilityHasValuesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
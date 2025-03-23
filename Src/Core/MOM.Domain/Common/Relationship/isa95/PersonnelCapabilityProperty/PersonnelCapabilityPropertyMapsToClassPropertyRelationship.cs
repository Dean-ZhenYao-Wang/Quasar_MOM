namespace MOM.Domain.Common.Relationship.isa95.PersonnelCapabilityProperty
{
    public class PersonnelCapabilityPropertyMapsToClassPropertyRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClassProperty>, IEquatable<PersonnelCapabilityPropertyMapsToClassPropertyRelationship>
    {
        public PersonnelCapabilityPropertyMapsToClassPropertyRelationship()
        {
            Name = "mapsToClassProperty";
        }

        public PersonnelCapabilityPropertyMapsToClassPropertyRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PersonnelCapabilityProperty source, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelCapabilityPropertyMapsToClassPropertyRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelCapabilityPropertyMapsToClassPropertyRelationship);
        }

        public bool Equals(PersonnelCapabilityPropertyMapsToClassPropertyRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelCapabilityPropertyMapsToClassPropertyRelationship? left, PersonnelCapabilityPropertyMapsToClassPropertyRelationship? right)
        {
            return EqualityComparer<PersonnelCapabilityPropertyMapsToClassPropertyRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelCapabilityPropertyMapsToClassPropertyRelationship? left, PersonnelCapabilityPropertyMapsToClassPropertyRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelCapabilityPropertyMapsToClassPropertyRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
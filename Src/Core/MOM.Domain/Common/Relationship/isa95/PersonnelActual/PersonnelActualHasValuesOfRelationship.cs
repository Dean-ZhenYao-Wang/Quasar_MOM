namespace MOM.Domain.Common.Relationship.isa95.PersonnelActual
{
    public class PersonnelActualHasValuesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PersonnelActualProperty>, IEquatable<PersonnelActualHasValuesOfRelationship>
    {
        public PersonnelActualHasValuesOfRelationship()
        {
            Name = "hasValuesOf";
        }

        public PersonnelActualHasValuesOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PersonnelActual source, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PersonnelActualProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelActualHasValuesOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelActualHasValuesOfRelationship);
        }

        public bool Equals(PersonnelActualHasValuesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelActualHasValuesOfRelationship? left, PersonnelActualHasValuesOfRelationship? right)
        {
            return EqualityComparer<PersonnelActualHasValuesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelActualHasValuesOfRelationship? left, PersonnelActualHasValuesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelActualHasValuesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
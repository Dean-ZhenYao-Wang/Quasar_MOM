namespace MOM.Domain.Common.Relationship.isa95.PersonnelActual
{
    public class PersonnelActualOperationalLocationRelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>, IEquatable<PersonnelActualOperationalLocationRelRelationship>
    {
        public PersonnelActualOperationalLocationRelRelationship()
        {
            Name = "operationalLocationRel";
        }

        public PersonnelActualOperationalLocationRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PersonnelActual source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelActualOperationalLocationRelRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelActualOperationalLocationRelRelationship);
        }

        public bool Equals(PersonnelActualOperationalLocationRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelActualOperationalLocationRelRelationship? left, PersonnelActualOperationalLocationRelRelationship? right)
        {
            return EqualityComparer<PersonnelActualOperationalLocationRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelActualOperationalLocationRelRelationship? left, PersonnelActualOperationalLocationRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelActualOperationalLocationRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.PersonnelActual
{
    public class PersonnelActualIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PersonnelActual>, IEquatable<PersonnelActualIsMadeUpOfRelationship>
    {
        public PersonnelActualIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public PersonnelActualIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PersonnelActual source, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PersonnelActual target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public PersonnelActualIsMadeUpOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonnelActualIsMadeUpOfRelationship);
        }

        public bool Equals(PersonnelActualIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonnelActualIsMadeUpOfRelationship? left, PersonnelActualIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<PersonnelActualIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonnelActualIsMadeUpOfRelationship? left, PersonnelActualIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonnelActualIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
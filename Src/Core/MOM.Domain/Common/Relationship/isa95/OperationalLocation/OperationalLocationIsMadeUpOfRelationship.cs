namespace MOM.Domain.Common.Relationship.isa95.OperationalLocation
{
    public class OperationalLocationIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation ,Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>, IEquatable<OperationalLocationIsMadeUpOfRelationship>
    {
        public OperationalLocationIsMadeUpOfRelationship():base()
        {
            Name = "isMadeUpOf";
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationalLocationIsMadeUpOfRelationship);
        }

        public bool Equals(OperationalLocationIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationalLocationIsMadeUpOfRelationship? left, OperationalLocationIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<OperationalLocationIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationalLocationIsMadeUpOfRelationship? left, OperationalLocationIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationalLocationIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.OperationalLocationClass
{
    public class OperationalLocationClassIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClass ,Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClass>, IEquatable<OperationalLocationClassIsMadeUpOfRelationship>
    {
        public OperationalLocationClassIsMadeUpOfRelationship():base()
        {
            Name = "isMadeUpOf";
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationalLocationClassIsMadeUpOfRelationship);
        }

        public bool Equals(OperationalLocationClassIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationalLocationClassIsMadeUpOfRelationship? left, OperationalLocationClassIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<OperationalLocationClassIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationalLocationClassIsMadeUpOfRelationship? left, OperationalLocationClassIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationalLocationClassIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
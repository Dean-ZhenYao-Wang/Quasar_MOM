namespace MOM.Domain.Common.Relationship.isa95.OperationalLocation
{
    public class OperationalLocationHasValuesOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationProperty>, IEquatable<OperationalLocationHasValuesOfRelationship>
    {
        public OperationalLocationHasValuesOfRelationship()
        {
            Name = "hasValuesOf";
        }

        public OperationalLocationHasValuesOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationalLocationHasValuesOfRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationalLocationHasValuesOfRelationship);
        }

        public bool Equals(OperationalLocationHasValuesOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationalLocationHasValuesOfRelationship? left, OperationalLocationHasValuesOfRelationship? right)
        {
            return EqualityComparer<OperationalLocationHasValuesOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationalLocationHasValuesOfRelationship? left, OperationalLocationHasValuesOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationalLocationHasValuesOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.OperationalLocationProperty
{
    public class OperationalLocationPropertyMapsToRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClassProperty>, IEquatable<OperationalLocationPropertyMapsToRelationship>
    {
        public OperationalLocationPropertyMapsToRelationship()
        {
            Name = "mapsTo";
        }

        public OperationalLocationPropertyMapsToRelationship(Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationProperty source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClassProperty target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationalLocationPropertyMapsToRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationalLocationPropertyMapsToRelationship);
        }

        public bool Equals(OperationalLocationPropertyMapsToRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationalLocationPropertyMapsToRelationship? left, OperationalLocationPropertyMapsToRelationship? right)
        {
            return EqualityComparer<OperationalLocationPropertyMapsToRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationalLocationPropertyMapsToRelationship? left, OperationalLocationPropertyMapsToRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationalLocationPropertyMapsToRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
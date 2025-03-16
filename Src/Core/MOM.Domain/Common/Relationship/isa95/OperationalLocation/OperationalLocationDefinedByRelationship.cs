namespace MOM.Domain.Common.Relationship.isa95.OperationalLocation
{
    public class OperationalLocationDefinedByRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClass>, IEquatable<OperationalLocationDefinedByRelationship>
    {
        public OperationalLocationDefinedByRelationship()
        {
            Name = "definedBy";
        }

        public OperationalLocationDefinedByRelationship(Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation source, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocationClass target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationalLocationDefinedByRelationship(string sourceId, string targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationalLocationDefinedByRelationship);
        }

        public bool Equals(OperationalLocationDefinedByRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationalLocationDefinedByRelationship? left, OperationalLocationDefinedByRelationship? right)
        {
            return EqualityComparer<OperationalLocationDefinedByRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationalLocationDefinedByRelationship? left, OperationalLocationDefinedByRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationalLocationDefinedByRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
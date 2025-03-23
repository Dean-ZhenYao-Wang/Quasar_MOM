namespace MOM.Domain.Common.Relationship.isa95.OperationsSegmentCapability
{
    public class OperationsSegmentCapabilityIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.OperationsSegmentCapability>, IEquatable<OperationsSegmentCapabilityIsMadeUpOfRelationship>
    {
        public OperationsSegmentCapabilityIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public OperationsSegmentCapabilityIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.OperationsSegmentCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.OperationsSegmentCapability target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsSegmentCapabilityIsMadeUpOfRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsSegmentCapabilityIsMadeUpOfRelationship);
        }

        public bool Equals(OperationsSegmentCapabilityIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsSegmentCapabilityIsMadeUpOfRelationship? left, OperationsSegmentCapabilityIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<OperationsSegmentCapabilityIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsSegmentCapabilityIsMadeUpOfRelationship? left, OperationsSegmentCapabilityIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsSegmentCapabilityIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
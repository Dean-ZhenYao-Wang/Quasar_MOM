namespace MOM.Domain.Common.Relationship.isa95.ProcessSegmentCapability
{
    public class ProcessSegmentCapabilityIsMadeUpOfRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.ProcessSegmentCapability>, IEquatable<ProcessSegmentCapabilityIsMadeUpOfRelationship>
    {
        public ProcessSegmentCapabilityIsMadeUpOfRelationship()
        {
            Name = "isMadeUpOf";
        }

        public ProcessSegmentCapabilityIsMadeUpOfRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.ProcessSegmentCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.ProcessSegmentCapability target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public ProcessSegmentCapabilityIsMadeUpOfRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ProcessSegmentCapabilityIsMadeUpOfRelationship);
        }

        public bool Equals(ProcessSegmentCapabilityIsMadeUpOfRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ProcessSegmentCapabilityIsMadeUpOfRelationship? left, ProcessSegmentCapabilityIsMadeUpOfRelationship? right)
        {
            return EqualityComparer<ProcessSegmentCapabilityIsMadeUpOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ProcessSegmentCapabilityIsMadeUpOfRelationship? left, ProcessSegmentCapabilityIsMadeUpOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ProcessSegmentCapabilityIsMadeUpOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
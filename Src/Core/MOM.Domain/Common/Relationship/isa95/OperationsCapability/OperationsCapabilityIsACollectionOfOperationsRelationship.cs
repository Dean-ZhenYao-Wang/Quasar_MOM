namespace MOM.Domain.Common.Relationship.isa95.OperationsCapability
{
    public class OperationsCapabilityIsACollectionOfOperationsRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.OperationsSegmentCapability>, IEquatable<OperationsCapabilityIsACollectionOfOperationsRelationship>
    {
        public OperationsCapabilityIsACollectionOfOperationsRelationship()
        {
            Name = "isACollectionOfOperations";
        }

        public OperationsCapabilityIsACollectionOfOperationsRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.OperationsCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.OperationsSegmentCapability target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsCapabilityIsACollectionOfOperationsRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsCapabilityIsACollectionOfOperationsRelationship);
        }

        public bool Equals(OperationsCapabilityIsACollectionOfOperationsRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsCapabilityIsACollectionOfOperationsRelationship? left, OperationsCapabilityIsACollectionOfOperationsRelationship? right)
        {
            return EqualityComparer<OperationsCapabilityIsACollectionOfOperationsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsCapabilityIsACollectionOfOperationsRelationship? left, OperationsCapabilityIsACollectionOfOperationsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsCapabilityIsACollectionOfOperationsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
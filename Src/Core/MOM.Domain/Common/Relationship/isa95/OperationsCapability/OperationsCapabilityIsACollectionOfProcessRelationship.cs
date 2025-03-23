namespace MOM.Domain.Common.Relationship.isa95.OperationsCapability
{
    public class OperationsCapabilityIsACollectionOfProcessRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsCapability.ProcessSegmentCapability>, IEquatable<OperationsCapabilityIsACollectionOfProcessRelationship>
    {
        public OperationsCapabilityIsACollectionOfProcessRelationship()
        {
            Name = "isACollectionOfProcess";
        }

        public OperationsCapabilityIsACollectionOfProcessRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsCapability.OperationsCapability source, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.ProcessSegmentCapability target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public OperationsCapabilityIsACollectionOfProcessRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsCapabilityIsACollectionOfProcessRelationship);
        }

        public bool Equals(OperationsCapabilityIsACollectionOfProcessRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OperationsCapabilityIsACollectionOfProcessRelationship? left, OperationsCapabilityIsACollectionOfProcessRelationship? right)
        {
            return EqualityComparer<OperationsCapabilityIsACollectionOfProcessRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsCapabilityIsACollectionOfProcessRelationship? left, OperationsCapabilityIsACollectionOfProcessRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OperationsCapabilityIsACollectionOfProcessRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
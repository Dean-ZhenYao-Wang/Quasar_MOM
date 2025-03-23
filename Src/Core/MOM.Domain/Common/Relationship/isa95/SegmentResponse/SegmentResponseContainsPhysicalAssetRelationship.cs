namespace MOM.Domain.Common.Relationship.isa95.SegmentResponse
{
    public class SegmentResponseContainsPhysicalAssetRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PhysicalAssetActual>, IEquatable<SegmentResponseContainsPhysicalAssetRelationship>
    {
        public SegmentResponseContainsPhysicalAssetRelationship()
        {
            Name = "containsPhysicalAsset";
        }

        public SegmentResponseContainsPhysicalAssetRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.SegmentResponse source, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PhysicalAssetActual target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public SegmentResponseContainsPhysicalAssetRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentResponseContainsPhysicalAssetRelationship);
        }

        public bool Equals(SegmentResponseContainsPhysicalAssetRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SegmentResponseContainsPhysicalAssetRelationship? left, SegmentResponseContainsPhysicalAssetRelationship? right)
        {
            return EqualityComparer<SegmentResponseContainsPhysicalAssetRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentResponseContainsPhysicalAssetRelationship? left, SegmentResponseContainsPhysicalAssetRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SegmentResponseContainsPhysicalAssetRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
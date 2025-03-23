namespace MOM.Domain.Common.Relationship.isa95.SegmentResponse
{
    public class SegmentResponseContainsMaterialRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActual>, IEquatable<SegmentResponseContainsMaterialRelationship>
    {
        public SegmentResponseContainsMaterialRelationship()
        {
            Name = "containsMaterial";
        }

        public SegmentResponseContainsMaterialRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.SegmentResponse source, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActual target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public SegmentResponseContainsMaterialRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentResponseContainsMaterialRelationship);
        }

        public bool Equals(SegmentResponseContainsMaterialRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SegmentResponseContainsMaterialRelationship? left, SegmentResponseContainsMaterialRelationship? right)
        {
            return EqualityComparer<SegmentResponseContainsMaterialRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentResponseContainsMaterialRelationship? left, SegmentResponseContainsMaterialRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SegmentResponseContainsMaterialRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
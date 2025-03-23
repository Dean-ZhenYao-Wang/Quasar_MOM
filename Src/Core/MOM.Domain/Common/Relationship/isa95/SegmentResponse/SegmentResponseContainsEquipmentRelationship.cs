namespace MOM.Domain.Common.Relationship.isa95.SegmentResponse
{
    public class SegmentResponseContainsEquipmentRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.EquipmentActual>, IEquatable<SegmentResponseContainsEquipmentRelationship>
    {
        public SegmentResponseContainsEquipmentRelationship()
        {
            Name = "containsEquipment";
        }

        public SegmentResponseContainsEquipmentRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.SegmentResponse source, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.EquipmentActual target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public SegmentResponseContainsEquipmentRelationship(Guid sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentResponseContainsEquipmentRelationship);
        }

        public bool Equals(SegmentResponseContainsEquipmentRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SegmentResponseContainsEquipmentRelationship? left, SegmentResponseContainsEquipmentRelationship? right)
        {
            return EqualityComparer<SegmentResponseContainsEquipmentRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentResponseContainsEquipmentRelationship? left, SegmentResponseContainsEquipmentRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SegmentResponseContainsEquipmentRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
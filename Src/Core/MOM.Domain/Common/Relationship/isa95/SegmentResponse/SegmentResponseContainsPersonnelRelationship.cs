namespace MOM.Domain.Common.Relationship.isa95.SegmentResponse
{
    public class SegmentResponseContainsPersonnelRelationship : Relationship<Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PersonnelActual>, IEquatable<SegmentResponseContainsPersonnelRelationship>
    {
        public SegmentResponseContainsPersonnelRelationship()
        {
            Name = "containsPersonnel";
        }

        public SegmentResponseContainsPersonnelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.SegmentResponse source, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PersonnelActual target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public SegmentResponseContainsPersonnelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentResponseContainsPersonnelRelationship);
        }

        public bool Equals(SegmentResponseContainsPersonnelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SegmentResponseContainsPersonnelRelationship? left, SegmentResponseContainsPersonnelRelationship? right)
        {
            return EqualityComparer<SegmentResponseContainsPersonnelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentResponseContainsPersonnelRelationship? left, SegmentResponseContainsPersonnelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SegmentResponseContainsPersonnelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
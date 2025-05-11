namespace MOM.Domain.Common.Relationship.isa95.RequestedSegmentResponse
{
    public class RequestedSegmentResponseHierarchyScopeRelRelationship : Relationship<Domain.isa95.CommonObjectModels.HierarchyScope>, IEquatable<RequestedSegmentResponseHierarchyScopeRelRelationship>
    {
        public RequestedSegmentResponseHierarchyScopeRelRelationship()
        {
            Name = "hierarchyScopeRel";
        }

        public RequestedSegmentResponseHierarchyScopeRelRelationship(Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.RequestedSegmentResponse source, Domain.isa95.CommonObjectModels.HierarchyScope target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public RequestedSegmentResponseHierarchyScopeRelRelationship(Guid? sourceId, Guid targetId) : this()
        {
            InitializeFromTwins(sourceId, targetId);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as RequestedSegmentResponseHierarchyScopeRelRelationship);
        }

        public bool Equals(RequestedSegmentResponseHierarchyScopeRelRelationship? other)
        {
            return other is not null && DtId == other.DtId && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(RequestedSegmentResponseHierarchyScopeRelRelationship? left, RequestedSegmentResponseHierarchyScopeRelRelationship? right)
        {
            return EqualityComparer<RequestedSegmentResponseHierarchyScopeRelRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(RequestedSegmentResponseHierarchyScopeRelRelationship? left, RequestedSegmentResponseHierarchyScopeRelRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(DtId.GetHashCode(), SourceId?.GetHashCode(), TargetId.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as RequestedSegmentResponseHierarchyScopeRelRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}
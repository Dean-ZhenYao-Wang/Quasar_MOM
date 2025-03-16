namespace MOM.Domain.Common.Relationship.isa95.RequestedSegmentResponse
{
    public class RequestedSegmentResponseHierarchyScopeRelRelationshipCollection : RelationshipCollection<RequestedSegmentResponseHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public RequestedSegmentResponseHierarchyScopeRelRelationshipCollection(IEnumerable<RequestedSegmentResponseHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<RequestedSegmentResponseHierarchyScopeRelRelationship>())
        {
        }
    }
}
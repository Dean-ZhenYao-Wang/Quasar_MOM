namespace MOM.Domain.Common.Relationship.isa95.SegmentResponse
{
    public class SegmentResponseHierarchyScopeRelRelationshipCollection : RelationshipCollection<SegmentResponseHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public SegmentResponseHierarchyScopeRelRelationshipCollection(IEnumerable<SegmentResponseHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SegmentResponseHierarchyScopeRelRelationship>())
        {
        }
    }
}
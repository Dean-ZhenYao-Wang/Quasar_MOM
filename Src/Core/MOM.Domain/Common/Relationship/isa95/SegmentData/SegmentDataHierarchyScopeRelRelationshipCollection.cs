namespace MOM.Domain.Common.Relationship.isa95.SegmentData
{
    public class SegmentDataHierarchyScopeRelRelationshipCollection : RelationshipCollection<SegmentDataHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public SegmentDataHierarchyScopeRelRelationshipCollection(IEnumerable<SegmentDataHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SegmentDataHierarchyScopeRelRelationship>())
        {
        }
    }
}
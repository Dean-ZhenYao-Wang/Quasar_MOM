namespace MOM.Domain.Common.Relationship.isa95.ProcessSegment
{
    public class ProcessSegmentHierarchyScopeRelRelationshipCollection : RelationshipCollection<ProcessSegmentHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public ProcessSegmentHierarchyScopeRelRelationshipCollection(IEnumerable<ProcessSegmentHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ProcessSegmentHierarchyScopeRelRelationship>())
        {
        }
    }
}
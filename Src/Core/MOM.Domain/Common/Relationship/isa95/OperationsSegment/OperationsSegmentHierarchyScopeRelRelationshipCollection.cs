namespace MOM.Domain.Common.Relationship.isa95.OperationsSegment
{
    public class OperationsSegmentHierarchyScopeRelRelationshipCollection : RelationshipCollection<OperationsSegmentHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public OperationsSegmentHierarchyScopeRelRelationshipCollection(IEnumerable<OperationsSegmentHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsSegmentHierarchyScopeRelRelationship>())
        {
        }
    }
}
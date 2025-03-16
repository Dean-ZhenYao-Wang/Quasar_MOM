namespace MOM.Domain.Common.Relationship.isa95.WorkRequest
{
    public class WorkRequestHierarchyScopeRelRelationshipCollection : RelationshipCollection<WorkRequestHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public WorkRequestHierarchyScopeRelRelationshipCollection(IEnumerable<WorkRequestHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkRequestHierarchyScopeRelRelationship>())
        {
        }
    }
}
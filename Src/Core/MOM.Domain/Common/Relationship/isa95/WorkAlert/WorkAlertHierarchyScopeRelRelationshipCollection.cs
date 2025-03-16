namespace MOM.Domain.Common.Relationship.isa95.WorkAlert
{
    public class WorkAlertHierarchyScopeRelRelationshipCollection : RelationshipCollection<WorkAlertHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public WorkAlertHierarchyScopeRelRelationshipCollection(IEnumerable<WorkAlertHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkAlertHierarchyScopeRelRelationship>())
        {
        }
    }
}
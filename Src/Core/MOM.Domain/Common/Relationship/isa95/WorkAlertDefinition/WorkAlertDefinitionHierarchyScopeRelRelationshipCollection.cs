namespace MOM.Domain.Common.Relationship.isa95.WorkAlertDefinition
{
    public class WorkAlertDefinitionHierarchyScopeRelRelationshipCollection : RelationshipCollection<WorkAlertDefinitionHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public WorkAlertDefinitionHierarchyScopeRelRelationshipCollection(IEnumerable<WorkAlertDefinitionHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkAlertDefinitionHierarchyScopeRelRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.WorkCalendarDefinition
{
    public class WorkCalendarDefinitionHierarchyScopeRelRelationshipCollection : RelationshipCollection<WorkCalendarDefinitionHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public WorkCalendarDefinitionHierarchyScopeRelRelationshipCollection(IEnumerable<WorkCalendarDefinitionHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkCalendarDefinitionHierarchyScopeRelRelationship>())
        {
        }
    }
}
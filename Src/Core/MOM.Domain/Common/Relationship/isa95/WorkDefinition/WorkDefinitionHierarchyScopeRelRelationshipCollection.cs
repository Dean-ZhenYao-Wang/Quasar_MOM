namespace MOM.Domain.Common.Relationship.isa95.WorkDefinition
{
    public class WorkDefinitionHierarchyScopeRelRelationshipCollection : RelationshipCollection<WorkDefinitionHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public WorkDefinitionHierarchyScopeRelRelationshipCollection(IEnumerable<WorkDefinitionHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkDefinitionHierarchyScopeRelRelationship>())
        {
        }
    }
}
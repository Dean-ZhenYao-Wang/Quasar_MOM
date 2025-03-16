namespace MOM.Domain.Common.Relationship.isa95.OperationsDefinition
{
    public class OperationsDefinitionHierarchyScopeRelRelationshipCollection : RelationshipCollection<OperationsDefinitionHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public OperationsDefinitionHierarchyScopeRelRelationshipCollection(IEnumerable<OperationsDefinitionHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsDefinitionHierarchyScopeRelRelationship>())
        {
        }
    }
}
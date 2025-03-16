namespace MOM.Domain.Common.Relationship.isa95.OperationsEventDefinition
{
    public class OperationsEventDefinitionHierarchyScopeRelRelationshipCollection : RelationshipCollection<OperationsEventDefinitionHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public OperationsEventDefinitionHierarchyScopeRelRelationshipCollection(IEnumerable<OperationsEventDefinitionHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsEventDefinitionHierarchyScopeRelRelationship>())
        {
        }
    }
}
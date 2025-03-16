namespace MOM.Domain.Common.Relationship.isa95.OperationalLocationClass
{
    public class OperationalLocationClassHierarchyScopeRelRelationshipCollection : RelationshipCollection<OperationalLocationClassHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public OperationalLocationClassHierarchyScopeRelRelationshipCollection(IEnumerable<OperationalLocationClassHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationalLocationClassHierarchyScopeRelRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.OperationalLocation
{
    public class OperationalLocationHierarchyScopeRelRelationshipCollection : RelationshipCollection<OperationalLocationHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public OperationalLocationHierarchyScopeRelRelationshipCollection(IEnumerable<OperationalLocationHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationalLocationHierarchyScopeRelRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.TestSpecification
{
    public class TestSpecificationHierarchyScopeRelRelationshipCollection : RelationshipCollection<TestSpecificationHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public TestSpecificationHierarchyScopeRelRelationshipCollection(IEnumerable<TestSpecificationHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<TestSpecificationHierarchyScopeRelRelationship>())
        {
        }
    }
}
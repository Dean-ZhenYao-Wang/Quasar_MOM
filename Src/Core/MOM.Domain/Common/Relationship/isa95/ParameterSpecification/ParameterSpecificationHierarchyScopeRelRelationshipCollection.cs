namespace MOM.Domain.Common.Relationship.isa95.ParameterSpecification
{
    public class ParameterSpecificationHierarchyScopeRelRelationshipCollection : RelationshipCollection<ParameterSpecificationHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public ParameterSpecificationHierarchyScopeRelRelationshipCollection(IEnumerable<ParameterSpecificationHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ParameterSpecificationHierarchyScopeRelRelationship>())
        {
        }
    }
}
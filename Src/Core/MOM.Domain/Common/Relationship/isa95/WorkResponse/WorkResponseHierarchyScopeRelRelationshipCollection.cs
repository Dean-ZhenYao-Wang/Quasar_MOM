namespace MOM.Domain.Common.Relationship.isa95.WorkResponse
{
    public class WorkResponseHierarchyScopeRelRelationshipCollection : RelationshipCollection<WorkResponseHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public WorkResponseHierarchyScopeRelRelationshipCollection(IEnumerable<WorkResponseHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkResponseHierarchyScopeRelRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.JobOrder
{
    public class JobOrderHierarchyScopeRelRelationshipCollection : RelationshipCollection<JobOrderHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public JobOrderHierarchyScopeRelRelationshipCollection(IEnumerable<JobOrderHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobOrderHierarchyScopeRelRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.JobResponse
{
    public class JobResponseHierarchyScopeRelRelationshipCollection : RelationshipCollection<JobResponseHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public JobResponseHierarchyScopeRelRelationshipCollection(IEnumerable<JobResponseHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobResponseHierarchyScopeRelRelationship>())
        {
        }
    }
}
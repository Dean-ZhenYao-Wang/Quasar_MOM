namespace MOM.Domain.Common.Relationship.isa95.JobList
{
    public class JobListHierarchyScopeRelRelationshipCollection : RelationshipCollection<JobListHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public JobListHierarchyScopeRelRelationshipCollection(IEnumerable<JobListHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobListHierarchyScopeRelRelationship>())
        {
        }
    }
}
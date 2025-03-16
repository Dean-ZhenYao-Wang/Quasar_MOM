namespace MOM.Domain.Common.Relationship.isa95.JobResponseList
{
    public class JobResponseListHierarchyScopeRelRelationshipCollection : RelationshipCollection<JobResponseListHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public JobResponseListHierarchyScopeRelRelationshipCollection(IEnumerable<JobResponseListHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobResponseListHierarchyScopeRelRelationship>())
        {
        }
    }
}
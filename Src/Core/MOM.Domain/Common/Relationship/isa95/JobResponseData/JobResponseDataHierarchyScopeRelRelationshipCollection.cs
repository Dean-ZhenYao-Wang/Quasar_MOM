namespace MOM.Domain.Common.Relationship.isa95.JobResponseData
{
    public class JobResponseDataHierarchyScopeRelRelationshipCollection : RelationshipCollection<JobResponseDataHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public JobResponseDataHierarchyScopeRelRelationshipCollection(IEnumerable<JobResponseDataHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobResponseDataHierarchyScopeRelRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.JobOrderParameter
{
    public class JobOrderParameterHierarchyScopeRelRelationshipCollection : RelationshipCollection<JobOrderParameterHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public JobOrderParameterHierarchyScopeRelRelationshipCollection(IEnumerable<JobOrderParameterHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobOrderParameterHierarchyScopeRelRelationship>())
        {
        }
    }
}
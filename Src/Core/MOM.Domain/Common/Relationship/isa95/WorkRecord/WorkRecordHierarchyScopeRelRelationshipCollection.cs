namespace MOM.Domain.Common.Relationship.isa95.WorkRecord
{
    public class WorkRecordHierarchyScopeRelRelationshipCollection : RelationshipCollection<WorkRecordHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public WorkRecordHierarchyScopeRelRelationshipCollection(IEnumerable<WorkRecordHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkRecordHierarchyScopeRelRelationship>())
        {
        }
    }
}
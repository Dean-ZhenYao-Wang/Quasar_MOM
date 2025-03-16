namespace MOM.Domain.Common.Relationship.isa95.ProcessSegmentParameter
{
    public class ProcessSegmentParameterHierarchyScopeRelRelationshipCollection : RelationshipCollection<ProcessSegmentParameterHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public ProcessSegmentParameterHierarchyScopeRelRelationshipCollection(IEnumerable<ProcessSegmentParameterHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ProcessSegmentParameterHierarchyScopeRelRelationship>())
        {
        }
    }
}
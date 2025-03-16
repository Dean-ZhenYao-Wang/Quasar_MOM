namespace MOM.Domain.Common.Relationship.isa95.SegmentParameter
{
    public class SegmentParameterHierarchyScopeRelRelationshipCollection : RelationshipCollection<SegmentParameterHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public SegmentParameterHierarchyScopeRelRelationshipCollection(IEnumerable<SegmentParameterHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SegmentParameterHierarchyScopeRelRelationship>())
        {
        }
    }
}
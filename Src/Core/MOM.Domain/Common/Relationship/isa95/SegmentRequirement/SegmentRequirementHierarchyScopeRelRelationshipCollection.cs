namespace MOM.Domain.Common.Relationship.isa95.SegmentRequirement
{
    public class SegmentRequirementHierarchyScopeRelRelationshipCollection : RelationshipCollection<SegmentRequirementHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public SegmentRequirementHierarchyScopeRelRelationshipCollection(IEnumerable<SegmentRequirementHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SegmentRequirementHierarchyScopeRelRelationship>())
        {
        }
    }
}
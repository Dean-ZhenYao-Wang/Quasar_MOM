namespace MOM.Domain.Common.Relationship.isa95.SegmentRequirement
{
    public class SegmentRequirementContainsMaterialRelationshipCollection : RelationshipCollection<SegmentRequirementContainsMaterialRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirement>
    {
        public SegmentRequirementContainsMaterialRelationshipCollection(IEnumerable<SegmentRequirementContainsMaterialRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SegmentRequirementContainsMaterialRelationship>())
        {
        }
    }
}
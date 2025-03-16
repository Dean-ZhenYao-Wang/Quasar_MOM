namespace MOM.Domain.Common.Relationship.isa95.SegmentRequirement
{
    public class SegmentRequirementContainsPhysicalAssetRelationshipCollection : RelationshipCollection<SegmentRequirementContainsPhysicalAssetRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PhysicalAssetRequirement>
    {
        public SegmentRequirementContainsPhysicalAssetRelationshipCollection(IEnumerable<SegmentRequirementContainsPhysicalAssetRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SegmentRequirementContainsPhysicalAssetRelationship>())
        {
        }
    }
}
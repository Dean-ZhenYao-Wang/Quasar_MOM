namespace MOM.Domain.Common.Relationship.isa95.SegmentRequirement
{
    public class SegmentRequirementContainsPersonnelRelationshipCollection : RelationshipCollection<SegmentRequirementContainsPersonnelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PersonnelRequirement>
    {
        public SegmentRequirementContainsPersonnelRelationshipCollection(IEnumerable<SegmentRequirementContainsPersonnelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SegmentRequirementContainsPersonnelRelationship>())
        {
        }
    }
}
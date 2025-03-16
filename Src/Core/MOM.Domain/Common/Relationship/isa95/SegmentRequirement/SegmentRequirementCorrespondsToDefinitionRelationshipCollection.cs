namespace MOM.Domain.Common.Relationship.isa95.SegmentRequirement
{
    public class SegmentRequirementCorrespondsToDefinitionRelationshipCollection : RelationshipCollection<SegmentRequirementCorrespondsToDefinitionRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsDefinition>
    {
        public SegmentRequirementCorrespondsToDefinitionRelationshipCollection(IEnumerable<SegmentRequirementCorrespondsToDefinitionRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SegmentRequirementCorrespondsToDefinitionRelationship>())
        {
        }
    }
}
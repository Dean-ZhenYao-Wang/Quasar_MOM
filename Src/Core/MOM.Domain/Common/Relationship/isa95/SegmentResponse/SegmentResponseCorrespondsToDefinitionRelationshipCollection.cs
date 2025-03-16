namespace MOM.Domain.Common.Relationship.isa95.SegmentResponse
{
    public class SegmentResponseCorrespondsToDefinitionRelationshipCollection : RelationshipCollection<SegmentResponseCorrespondsToDefinitionRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsDefinition>
    {
        public SegmentResponseCorrespondsToDefinitionRelationshipCollection(IEnumerable<SegmentResponseCorrespondsToDefinitionRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SegmentResponseCorrespondsToDefinitionRelationship>())
        {
        }
    }
}
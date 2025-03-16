namespace MOM.Domain.Common.Relationship.isa95.RequestedSegmentResponse
{
    public class RequestedSegmentResponseCorrespondsToDefinitionRelationshipCollection : RelationshipCollection<RequestedSegmentResponseCorrespondsToDefinitionRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsDefinition>
    {
        public RequestedSegmentResponseCorrespondsToDefinitionRelationshipCollection(IEnumerable<RequestedSegmentResponseCorrespondsToDefinitionRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<RequestedSegmentResponseCorrespondsToDefinitionRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.OperationsSegment
{
    public class OperationsSegmentContainsParameterRelationshipCollection : RelationshipCollection<OperationsSegmentContainsParameterRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.ParameterSpecification>
    {
        public OperationsSegmentContainsParameterRelationshipCollection(IEnumerable<OperationsSegmentContainsParameterRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsSegmentContainsParameterRelationship>())
        {
        }
    }
}
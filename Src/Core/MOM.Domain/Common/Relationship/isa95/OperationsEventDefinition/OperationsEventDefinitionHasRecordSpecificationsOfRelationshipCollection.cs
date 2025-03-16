namespace MOM.Domain.Common.Relationship.isa95.OperationsEventDefinition
{
    public class OperationsEventDefinitionHasRecordSpecificationsOfRelationshipCollection : RelationshipCollection<OperationsEventDefinitionHasRecordSpecificationsOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinitionRecordSpecification>
    {
        public OperationsEventDefinitionHasRecordSpecificationsOfRelationshipCollection(IEnumerable<OperationsEventDefinitionHasRecordSpecificationsOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsEventDefinitionHasRecordSpecificationsOfRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.OperationsEventDefinitionRecordSpecification
{
    public class OperationsEventDefinitionRecordSpecificationContainsRelationshipCollection : RelationshipCollection<OperationsEventDefinitionRecordSpecificationContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinitionRecordSpecification>
    {
        public OperationsEventDefinitionRecordSpecificationContainsRelationshipCollection(IEnumerable<OperationsEventDefinitionRecordSpecificationContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsEventDefinitionRecordSpecificationContainsRelationship>())
        {
        }
    }
}
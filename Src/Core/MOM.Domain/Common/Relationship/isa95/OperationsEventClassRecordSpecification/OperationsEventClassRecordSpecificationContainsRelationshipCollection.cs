namespace MOM.Domain.Common.Relationship.isa95.OperationsEventClassRecordSpecification
{
    public class OperationsEventClassRecordSpecificationContainsRelationshipCollection : RelationshipCollection<OperationsEventClassRecordSpecificationContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinitionRecordSpecification>
    {
        public OperationsEventClassRecordSpecificationContainsRelationshipCollection(IEnumerable<OperationsEventClassRecordSpecificationContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsEventClassRecordSpecificationContainsRelationship>())
        {
        }
    }
}
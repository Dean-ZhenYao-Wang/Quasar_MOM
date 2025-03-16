namespace MOM.Domain.Common.Relationship.isa95.OperationsEventClass
{
    public class OperationsEventClassHasRecordSpecificationOfRelationshipCollection : RelationshipCollection<OperationsEventClassHasRecordSpecificationOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClassRecordSpecification>
    {
        public OperationsEventClassHasRecordSpecificationOfRelationshipCollection(IEnumerable<OperationsEventClassHasRecordSpecificationOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsEventClassHasRecordSpecificationOfRelationship>())
        {
        }
    }
}
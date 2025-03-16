namespace MOM.Domain.Common.Relationship.isa95.OperationsEventDefinitionRecordSpecification
{
    public class OperationsEventDefinitionRecordSpecificationMapsToRelationshipCollection : RelationshipCollection<OperationsEventDefinitionRecordSpecificationMapsToRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventClassRecordSpecification>
    {
        public OperationsEventDefinitionRecordSpecificationMapsToRelationshipCollection(IEnumerable<OperationsEventDefinitionRecordSpecificationMapsToRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsEventDefinitionRecordSpecificationMapsToRelationship>())
        {
        }
    }
}
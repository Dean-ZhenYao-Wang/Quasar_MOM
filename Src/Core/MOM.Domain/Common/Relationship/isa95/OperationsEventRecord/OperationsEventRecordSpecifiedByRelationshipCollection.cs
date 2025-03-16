namespace MOM.Domain.Common.Relationship.isa95.OperationsEventRecord
{
    public class OperationsEventRecordSpecifiedByRelationshipCollection : RelationshipCollection<OperationsEventRecordSpecifiedByRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventDefinitionRecordSpecification>
    {
        public OperationsEventRecordSpecifiedByRelationshipCollection(IEnumerable<OperationsEventRecordSpecifiedByRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsEventRecordSpecifiedByRelationship>())
        {
        }
    }
}
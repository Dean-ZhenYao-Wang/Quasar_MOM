namespace MOM.Domain.Common.Relationship.isa95.OperationsEventRecord
{
    public class OperationsEventRecordContainsRelationshipCollection : RelationshipCollection<OperationsEventRecordContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventRecord>
    {
        public OperationsEventRecordContainsRelationshipCollection(IEnumerable<OperationsEventRecordContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsEventRecordContainsRelationship>())
        {
        }
    }
}
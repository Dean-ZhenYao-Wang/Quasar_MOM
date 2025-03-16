namespace MOM.Domain.Common.Relationship.isa95.OperationsEventRecord
{
    public class OperationsEventRecordRecordsActionOnRelationshipCollection : RelationshipCollection<OperationsEventRecordRecordsActionOnRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventRecordEntry>
    {
        public OperationsEventRecordRecordsActionOnRelationshipCollection(IEnumerable<OperationsEventRecordRecordsActionOnRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsEventRecordRecordsActionOnRelationship>())
        {
        }
    }
}
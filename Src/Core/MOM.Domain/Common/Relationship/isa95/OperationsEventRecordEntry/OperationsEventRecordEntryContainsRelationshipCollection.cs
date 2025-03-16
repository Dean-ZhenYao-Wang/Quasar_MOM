namespace MOM.Domain.Common.Relationship.isa95.OperationsEventRecordEntry
{
    public class OperationsEventRecordEntryContainsRelationshipCollection : RelationshipCollection<OperationsEventRecordEntryContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsEvent.OperationsEventRecordEntry>
    {
        public OperationsEventRecordEntryContainsRelationshipCollection(IEnumerable<OperationsEventRecordEntryContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsEventRecordEntryContainsRelationship>())
        {
        }
    }
}
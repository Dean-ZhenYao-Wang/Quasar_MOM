namespace MOM.Domain.Common.Relationship.isa95.OperationsEventRecordEntry
{
    public class OperationsEventRecordEntryCorrespondsToAnEntryInRelationshipCollection : RelationshipCollection<OperationsEventRecordEntryCorrespondsToAnEntryInRelationship, BaseEntity>
    {
        public OperationsEventRecordEntryCorrespondsToAnEntryInRelationshipCollection(IEnumerable<OperationsEventRecordEntryCorrespondsToAnEntryInRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsEventRecordEntryCorrespondsToAnEntryInRelationship>())
        {
        }
    }
}
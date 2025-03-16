namespace MOM.Domain.Common.Relationship.isa95.OperationsEventRecordEntry
{
    public class OperationsEventRecordEntryCorrespondsToAnExternalEntryInRelationshipCollection : RelationshipCollection<OperationsEventRecordEntryCorrespondsToAnExternalEntryInRelationship, BaseEntity>
    {
        public OperationsEventRecordEntryCorrespondsToAnExternalEntryInRelationshipCollection(IEnumerable<OperationsEventRecordEntryCorrespondsToAnExternalEntryInRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsEventRecordEntryCorrespondsToAnExternalEntryInRelationship>())
        {
        }
    }
}
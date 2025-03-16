namespace MOM.Domain.Common.Relationship.isa95.WorkRecordEntry
{
    public class WorkRecordEntryCorrespondsToAnEntryInRelationshipCollection : RelationshipCollection<WorkRecordEntryCorrespondsToAnEntryInRelationship, BaseEntity>
    {
        public WorkRecordEntryCorrespondsToAnEntryInRelationshipCollection(IEnumerable<WorkRecordEntryCorrespondsToAnEntryInRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkRecordEntryCorrespondsToAnEntryInRelationship>())
        {
        }
    }
}
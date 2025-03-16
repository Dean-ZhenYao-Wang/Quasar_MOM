namespace MOM.Domain.Common.Relationship.isa95.WorkRecordEntry
{
    public class WorkRecordEntryCorrespondsToAnExternalEntryInRelationshipCollection : RelationshipCollection<WorkRecordEntryCorrespondsToAnExternalEntryInRelationship, BaseEntity>
    {
        public WorkRecordEntryCorrespondsToAnExternalEntryInRelationshipCollection(IEnumerable<WorkRecordEntryCorrespondsToAnExternalEntryInRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkRecordEntryCorrespondsToAnExternalEntryInRelationship>())
        {
        }
    }
}
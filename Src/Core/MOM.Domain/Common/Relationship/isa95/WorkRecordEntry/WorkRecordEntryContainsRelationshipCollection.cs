namespace MOM.Domain.Common.Relationship.isa95.WorkRecordEntry
{
    public class WorkRecordEntryContainsRelationshipCollection : RelationshipCollection<WorkRecordEntryContainsRelationship, Domain.isa95.CommonObjectModels.Part4.WorkRecord.WorkRecordEntry>
    {
        public WorkRecordEntryContainsRelationshipCollection(IEnumerable<WorkRecordEntryContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkRecordEntryContainsRelationship>())
        {
        }
    }
}
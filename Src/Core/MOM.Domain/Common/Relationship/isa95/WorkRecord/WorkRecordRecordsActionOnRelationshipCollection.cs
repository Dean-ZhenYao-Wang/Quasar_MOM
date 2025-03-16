namespace MOM.Domain.Common.Relationship.isa95.WorkRecord
{
    public class WorkRecordRecordsActionOnRelationshipCollection : RelationshipCollection<WorkRecordRecordsActionOnRelationship, Domain.isa95.CommonObjectModels.Part4.WorkRecord.WorkRecordEntry>
    {
        public WorkRecordRecordsActionOnRelationshipCollection(IEnumerable<WorkRecordRecordsActionOnRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkRecordRecordsActionOnRelationship>())
        {
        }
    }
}
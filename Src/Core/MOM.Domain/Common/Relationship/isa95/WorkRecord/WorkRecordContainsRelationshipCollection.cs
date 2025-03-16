namespace MOM.Domain.Common.Relationship.isa95.WorkRecord
{
    public class WorkRecordContainsRelationshipCollection : RelationshipCollection<WorkRecordContainsRelationship, Domain.isa95.CommonObjectModels.Part4.WorkRecord.WorkRecord>
    {
        public WorkRecordContainsRelationshipCollection(IEnumerable<WorkRecordContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkRecordContainsRelationship>())
        {
        }
    }
}
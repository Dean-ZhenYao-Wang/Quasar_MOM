namespace MOM.Domain.Common.Relationship.isa95.OperationsRecordTemplate
{
    public class OperationsRecordTemplateRecordsActionOnRelationshipCollection : RelationshipCollection<OperationsRecordTemplateRecordsActionOnRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsRecord.OperationsRecordEntryTemplate>
    {
        public OperationsRecordTemplateRecordsActionOnRelationshipCollection(IEnumerable<OperationsRecordTemplateRecordsActionOnRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsRecordTemplateRecordsActionOnRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.OperationsRecordEntryTemplate
{
    public class OperationsRecordEntryTemplateContainsRelationshipCollection : RelationshipCollection<OperationsRecordEntryTemplateContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsRecord.OperationsRecordEntryTemplate>
    {
        public OperationsRecordEntryTemplateContainsRelationshipCollection(IEnumerable<OperationsRecordEntryTemplateContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsRecordEntryTemplateContainsRelationship>())
        {
        }
    }
}
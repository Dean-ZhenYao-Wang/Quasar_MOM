namespace MOM.Domain.Common.Relationship.isa95.OperationsRecordEntryTemplate
{
    public class OperationsRecordEntryTemplateCorrespondsToAnEntryInRelationshipCollection : RelationshipCollection<OperationsRecordEntryTemplateCorrespondsToAnEntryInRelationship, BaseEntity>
    {
        public OperationsRecordEntryTemplateCorrespondsToAnEntryInRelationshipCollection(IEnumerable<OperationsRecordEntryTemplateCorrespondsToAnEntryInRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsRecordEntryTemplateCorrespondsToAnEntryInRelationship>())
        {
        }
    }
}
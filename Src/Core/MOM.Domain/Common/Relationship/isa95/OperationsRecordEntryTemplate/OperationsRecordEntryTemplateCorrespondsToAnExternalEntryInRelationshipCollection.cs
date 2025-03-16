namespace MOM.Domain.Common.Relationship.isa95.OperationsRecordEntryTemplate
{
    public class OperationsRecordEntryTemplateCorrespondsToAnExternalEntryInRelationshipCollection : RelationshipCollection<OperationsRecordEntryTemplateCorrespondsToAnExternalEntryInRelationship, BaseEntity>
    {
        public OperationsRecordEntryTemplateCorrespondsToAnExternalEntryInRelationshipCollection(IEnumerable<OperationsRecordEntryTemplateCorrespondsToAnExternalEntryInRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsRecordEntryTemplateCorrespondsToAnExternalEntryInRelationship>())
        {
        }
    }
}
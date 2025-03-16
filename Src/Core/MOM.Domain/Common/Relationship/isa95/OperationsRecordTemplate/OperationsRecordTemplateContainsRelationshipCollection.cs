namespace MOM.Domain.Common.Relationship.isa95.OperationsRecordTemplate
{
    public class OperationsRecordTemplateContainsRelationshipCollection : RelationshipCollection<OperationsRecordTemplateContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsRecord.OperationsRecordTemplate>
    {
        public OperationsRecordTemplateContainsRelationshipCollection(IEnumerable<OperationsRecordTemplateContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsRecordTemplateContainsRelationship>())
        {
        }
    }
}
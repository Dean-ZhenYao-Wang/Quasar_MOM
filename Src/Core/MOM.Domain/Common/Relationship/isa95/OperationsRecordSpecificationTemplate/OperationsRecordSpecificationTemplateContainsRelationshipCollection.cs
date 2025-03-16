namespace MOM.Domain.Common.Relationship.isa95.OperationsRecordSpecificationTemplate
{
    public class OperationsRecordSpecificationTemplateContainsRelationshipCollection : RelationshipCollection<OperationsRecordSpecificationTemplateContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsRecord.OperationsRecordSpecificationTemplate>
    {
        public OperationsRecordSpecificationTemplateContainsRelationshipCollection(IEnumerable<OperationsRecordSpecificationTemplateContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsRecordSpecificationTemplateContainsRelationship>())
        {
        }
    }
}
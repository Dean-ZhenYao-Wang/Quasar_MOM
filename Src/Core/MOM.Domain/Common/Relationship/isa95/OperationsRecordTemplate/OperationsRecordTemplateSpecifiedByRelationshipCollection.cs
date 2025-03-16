namespace MOM.Domain.Common.Relationship.isa95.OperationsRecordTemplate
{
    public class OperationsRecordTemplateSpecifiedByRelationshipCollection : RelationshipCollection<OperationsRecordTemplateSpecifiedByRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsRecord.OperationsRecordSpecificationTemplate>
    {
        public OperationsRecordTemplateSpecifiedByRelationshipCollection(IEnumerable<OperationsRecordTemplateSpecifiedByRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsRecordTemplateSpecifiedByRelationship>())
        {
        }
    }
}
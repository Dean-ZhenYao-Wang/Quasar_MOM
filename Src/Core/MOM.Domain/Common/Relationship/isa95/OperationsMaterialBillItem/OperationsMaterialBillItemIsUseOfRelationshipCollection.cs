namespace MOM.Domain.Common.Relationship.isa95.OperationsMaterialBillItem
{
    public class OperationsMaterialBillItemIsUseOfRelationshipCollection : RelationshipCollection<OperationsMaterialBillItemIsUseOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecification>
    {
        public OperationsMaterialBillItemIsUseOfRelationshipCollection(IEnumerable<OperationsMaterialBillItemIsUseOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsMaterialBillItemIsUseOfRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.OperationsMaterialBillItem
{
    public class OperationsMaterialBillItemIsAssembledFromRelationshipCollection : RelationshipCollection<OperationsMaterialBillItemIsAssembledFromRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsMaterialBillItem>
    {
        public OperationsMaterialBillItemIsAssembledFromRelationshipCollection(IEnumerable<OperationsMaterialBillItemIsAssembledFromRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsMaterialBillItemIsAssembledFromRelationship>())
        {
        }
    }
}
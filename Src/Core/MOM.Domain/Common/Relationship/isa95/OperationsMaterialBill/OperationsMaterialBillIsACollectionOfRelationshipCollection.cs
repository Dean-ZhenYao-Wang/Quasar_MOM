namespace MOM.Domain.Common.Relationship.isa95.OperationsMaterialBill
{
    public class OperationsMaterialBillIsACollectionOfRelationshipCollection : RelationshipCollection<OperationsMaterialBillIsACollectionOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsMaterialBillItem>
    {
        public OperationsMaterialBillIsACollectionOfRelationshipCollection(IEnumerable<OperationsMaterialBillIsACollectionOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsMaterialBillIsACollectionOfRelationship>())
        {
        }
    }
}
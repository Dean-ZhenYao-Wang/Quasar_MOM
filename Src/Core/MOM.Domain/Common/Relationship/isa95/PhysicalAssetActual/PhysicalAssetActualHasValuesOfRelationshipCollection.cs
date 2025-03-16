namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetActual
{
    public class PhysicalAssetActualHasValuesOfRelationshipCollection : RelationshipCollection<PhysicalAssetActualHasValuesOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PhysicalAssetActualProperty>
    {
        public PhysicalAssetActualHasValuesOfRelationshipCollection(IEnumerable<PhysicalAssetActualHasValuesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetActualHasValuesOfRelationship>())
        {
        }
    }
}
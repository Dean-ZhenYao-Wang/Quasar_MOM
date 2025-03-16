namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetActual
{
    public class PhysicalAssetActualIsMadeUpOfRelationshipCollection : RelationshipCollection<PhysicalAssetActualIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PhysicalAssetActual>
    {
        public PhysicalAssetActualIsMadeUpOfRelationshipCollection(IEnumerable<PhysicalAssetActualIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetActualIsMadeUpOfRelationship>())
        {
        }
    }
}
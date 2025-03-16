namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetActualProperty
{
    public class PhysicalAssetActualPropertyContainsRelationshipCollection : RelationshipCollection<PhysicalAssetActualPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PhysicalAssetActualProperty>
    {
        public PhysicalAssetActualPropertyContainsRelationshipCollection(IEnumerable<PhysicalAssetActualPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetActualPropertyContainsRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSpecification
{
    public class PhysicalAssetSpecificationSpecifiesRelationshipCollection : RelationshipCollection<PhysicalAssetSpecificationSpecifiesRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification>
    {
        public PhysicalAssetSpecificationSpecifiesRelationshipCollection(IEnumerable<PhysicalAssetSpecificationSpecifiesRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetSpecificationSpecifiesRelationship>())
        {
        }
    }
}
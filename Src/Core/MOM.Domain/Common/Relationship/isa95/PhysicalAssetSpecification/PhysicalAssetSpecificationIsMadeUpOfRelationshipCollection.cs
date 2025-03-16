namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSpecification
{
    public class PhysicalAssetSpecificationIsMadeUpOfRelationshipCollection : RelationshipCollection<PhysicalAssetSpecificationIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PhysicalAssetSpecification>
    {
        public PhysicalAssetSpecificationIsMadeUpOfRelationshipCollection(IEnumerable<PhysicalAssetSpecificationIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetSpecificationIsMadeUpOfRelationship>())
        {
        }
    }
}
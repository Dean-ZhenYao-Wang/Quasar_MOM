namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSpecificationProperty
{
    public class PhysicalAssetSpecificationPropertyContainsRelationshipCollection : RelationshipCollection<PhysicalAssetSpecificationPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PhysicalAssetSpecificationProperty>
    {
        public PhysicalAssetSpecificationPropertyContainsRelationshipCollection(IEnumerable<PhysicalAssetSpecificationPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetSpecificationPropertyContainsRelationship>())
        {
        }
    }
}
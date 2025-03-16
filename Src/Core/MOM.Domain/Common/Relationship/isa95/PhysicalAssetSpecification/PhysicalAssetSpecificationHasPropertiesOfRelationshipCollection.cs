namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSpecification
{
    public class PhysicalAssetSpecificationHasPropertiesOfRelationshipCollection : RelationshipCollection<PhysicalAssetSpecificationHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PhysicalAssetSpecificationProperty>
    {
        public PhysicalAssetSpecificationHasPropertiesOfRelationshipCollection(IEnumerable<PhysicalAssetSpecificationHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetSpecificationHasPropertiesOfRelationship>())
        {
        }
    }
}
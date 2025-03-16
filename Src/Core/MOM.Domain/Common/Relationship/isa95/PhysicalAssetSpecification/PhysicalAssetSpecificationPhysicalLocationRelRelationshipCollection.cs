namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetSpecification
{
    public class PhysicalAssetSpecificationPhysicalLocationRelRelationshipCollection : RelationshipCollection<PhysicalAssetSpecificationPhysicalLocationRelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>
    {
        public PhysicalAssetSpecificationPhysicalLocationRelRelationshipCollection(IEnumerable<PhysicalAssetSpecificationPhysicalLocationRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetSpecificationPhysicalLocationRelRelationship>())
        {
        }
    }
}
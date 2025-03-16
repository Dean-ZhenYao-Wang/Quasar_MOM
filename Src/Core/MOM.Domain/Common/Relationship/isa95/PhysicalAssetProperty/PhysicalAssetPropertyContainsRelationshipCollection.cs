namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetProperty
{
    public class PhysicalAssetPropertyContainsRelationshipCollection : RelationshipCollection<PhysicalAssetPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetProperty>
    {
        public PhysicalAssetPropertyContainsRelationshipCollection(IEnumerable<PhysicalAssetPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetPropertyContainsRelationship>())
        {
        }
    }
}
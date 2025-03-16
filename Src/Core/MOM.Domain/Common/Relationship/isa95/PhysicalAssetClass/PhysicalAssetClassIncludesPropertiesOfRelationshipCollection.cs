namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetClass
{
    public class PhysicalAssetClassIncludesPropertiesOfRelationshipCollection : RelationshipCollection<PhysicalAssetClassIncludesPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass>
    {
        public PhysicalAssetClassIncludesPropertiesOfRelationshipCollection(IEnumerable<PhysicalAssetClassIncludesPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetClassIncludesPropertiesOfRelationship>())
        {
        }
    }
}
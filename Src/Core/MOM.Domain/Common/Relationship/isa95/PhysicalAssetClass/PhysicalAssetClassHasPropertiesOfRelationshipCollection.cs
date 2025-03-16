namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetClass
{
    public class PhysicalAssetClassHasPropertiesOfRelationshipCollection : RelationshipCollection<PhysicalAssetClassHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClassProperty>
    {
        public PhysicalAssetClassHasPropertiesOfRelationshipCollection(IEnumerable<PhysicalAssetClassHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetClassHasPropertiesOfRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetClassProperty
{
    public class PhysicalAssetClassPropertyContainsRelationshipCollection : RelationshipCollection<PhysicalAssetClassPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClassProperty>
    {
        public PhysicalAssetClassPropertyContainsRelationshipCollection(IEnumerable<PhysicalAssetClassPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetClassPropertyContainsRelationship>())
        {
        }
    }
}
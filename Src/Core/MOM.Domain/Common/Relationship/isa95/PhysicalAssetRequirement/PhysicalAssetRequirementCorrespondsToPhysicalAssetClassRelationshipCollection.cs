namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetRequirement
{
    public class PhysicalAssetRequirementCorrespondsToPhysicalAssetClassRelationshipCollection : RelationshipCollection<PhysicalAssetRequirementCorrespondsToPhysicalAssetClassRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass>
    {
        public PhysicalAssetRequirementCorrespondsToPhysicalAssetClassRelationshipCollection(IEnumerable<PhysicalAssetRequirementCorrespondsToPhysicalAssetClassRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetRequirementCorrespondsToPhysicalAssetClassRelationship>())
        {
        }
    }
}
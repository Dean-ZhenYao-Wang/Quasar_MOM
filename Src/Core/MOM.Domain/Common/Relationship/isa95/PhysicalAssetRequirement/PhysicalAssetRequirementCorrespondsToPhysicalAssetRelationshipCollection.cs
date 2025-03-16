namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetRequirement
{
    public class PhysicalAssetRequirementCorrespondsToPhysicalAssetRelationshipCollection : RelationshipCollection<PhysicalAssetRequirementCorrespondsToPhysicalAssetRelationship, Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset>
    {
        public PhysicalAssetRequirementCorrespondsToPhysicalAssetRelationshipCollection(IEnumerable<PhysicalAssetRequirementCorrespondsToPhysicalAssetRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetRequirementCorrespondsToPhysicalAssetRelationship>())
        {
        }
    }
}
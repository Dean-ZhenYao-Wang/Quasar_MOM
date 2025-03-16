namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetRequirement
{
    public class PhysicalAssetRequirementIsMadeUpOfRelationshipCollection : RelationshipCollection<PhysicalAssetRequirementIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PhysicalAssetRequirement>
    {
        public PhysicalAssetRequirementIsMadeUpOfRelationshipCollection(IEnumerable<PhysicalAssetRequirementIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetRequirementIsMadeUpOfRelationship>())
        {
        }
    }
}
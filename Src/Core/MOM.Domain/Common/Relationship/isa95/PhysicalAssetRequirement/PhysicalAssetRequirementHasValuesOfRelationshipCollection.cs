namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetRequirement
{
    public class PhysicalAssetRequirementHasValuesOfRelationshipCollection : RelationshipCollection<PhysicalAssetRequirementHasValuesOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PhysicalAssetRequirementProperty>
    {
        public PhysicalAssetRequirementHasValuesOfRelationshipCollection(IEnumerable<PhysicalAssetRequirementHasValuesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetRequirementHasValuesOfRelationship>())
        {
        }
    }
}
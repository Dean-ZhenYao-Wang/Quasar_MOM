namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetRequirementProperty
{
    public class PhysicalAssetRequirementPropertyContainsRelationshipCollection : RelationshipCollection<PhysicalAssetRequirementPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PhysicalAssetRequirementProperty>
    {
        public PhysicalAssetRequirementPropertyContainsRelationshipCollection(IEnumerable<PhysicalAssetRequirementPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetRequirementPropertyContainsRelationship>())
        {
        }
    }
}
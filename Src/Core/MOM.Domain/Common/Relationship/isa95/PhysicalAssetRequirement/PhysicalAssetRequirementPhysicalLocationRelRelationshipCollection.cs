namespace MOM.Domain.Common.Relationship.isa95.PhysicalAssetRequirement
{
    public class PhysicalAssetRequirementPhysicalLocationRelRelationshipCollection : RelationshipCollection<PhysicalAssetRequirementPhysicalLocationRelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>
    {
        public PhysicalAssetRequirementPhysicalLocationRelRelationshipCollection(IEnumerable<PhysicalAssetRequirementPhysicalLocationRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetRequirementPhysicalLocationRelRelationship>())
        {
        }
    }
}
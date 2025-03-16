namespace MOM.Domain.Common.Relationship.isa95.PhysicalAsset
{
    public class PhysicalAssetPhysicalLocationRelRelationshipCollection : RelationshipCollection<PhysicalAssetPhysicalLocationRelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>
    {
        public PhysicalAssetPhysicalLocationRelRelationshipCollection(IEnumerable<PhysicalAssetPhysicalLocationRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PhysicalAssetPhysicalLocationRelRelationship>())
        {
        }
    }
}
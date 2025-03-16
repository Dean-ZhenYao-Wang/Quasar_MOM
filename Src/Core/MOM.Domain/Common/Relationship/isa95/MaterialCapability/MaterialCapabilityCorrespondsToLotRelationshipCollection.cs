namespace MOM.Domain.Common.Relationship.isa95.MaterialCapability
{
    public class MaterialCapabilityCorrespondsToLotRelationshipCollection : RelationshipCollection<MaterialCapabilityCorrespondsToLotRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot>
    {
        public MaterialCapabilityCorrespondsToLotRelationshipCollection(IEnumerable<MaterialCapabilityCorrespondsToLotRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialCapabilityCorrespondsToLotRelationship>())
        {
        }
    }
}
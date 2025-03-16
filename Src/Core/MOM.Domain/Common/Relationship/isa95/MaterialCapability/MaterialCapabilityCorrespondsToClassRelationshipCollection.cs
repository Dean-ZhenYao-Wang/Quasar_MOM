namespace MOM.Domain.Common.Relationship.isa95.MaterialCapability
{
    public class MaterialCapabilityCorrespondsToClassRelationshipCollection : RelationshipCollection<MaterialCapabilityCorrespondsToClassRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass>
    {
        public MaterialCapabilityCorrespondsToClassRelationshipCollection(IEnumerable<MaterialCapabilityCorrespondsToClassRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialCapabilityCorrespondsToClassRelationship>())
        {
        }
    }
}
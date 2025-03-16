namespace MOM.Domain.Common.Relationship.isa95.MaterialCapability
{
    public class MaterialCapabilityCorrespondsToSublotRelationshipCollection : RelationshipCollection<MaterialCapabilityCorrespondsToSublotRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot>
    {
        public MaterialCapabilityCorrespondsToSublotRelationshipCollection(IEnumerable<MaterialCapabilityCorrespondsToSublotRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialCapabilityCorrespondsToSublotRelationship>())
        {
        }
    }
}
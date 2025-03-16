namespace MOM.Domain.Common.Relationship.isa95.MaterialCapability
{
    public class MaterialCapabilityCorrespondsToDefinitionRelationshipCollection : RelationshipCollection<MaterialCapabilityCorrespondsToDefinitionRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinition>
    {
        public MaterialCapabilityCorrespondsToDefinitionRelationshipCollection(IEnumerable<MaterialCapabilityCorrespondsToDefinitionRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialCapabilityCorrespondsToDefinitionRelationship>())
        {
        }
    }
}
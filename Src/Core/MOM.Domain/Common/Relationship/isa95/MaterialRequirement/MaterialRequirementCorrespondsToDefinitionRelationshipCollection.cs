namespace MOM.Domain.Common.Relationship.isa95.MaterialRequirement
{
    public class MaterialRequirementCorrespondsToDefinitionRelationshipCollection : RelationshipCollection<MaterialRequirementCorrespondsToDefinitionRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinition>
    {
        public MaterialRequirementCorrespondsToDefinitionRelationshipCollection(IEnumerable<MaterialRequirementCorrespondsToDefinitionRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialRequirementCorrespondsToDefinitionRelationship>())
        {
        }
    }
}
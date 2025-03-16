namespace MOM.Domain.Common.Relationship.isa95.MaterialSpecification
{
    public class MaterialSpecificationCorrespondsToDefinitionRelationshipCollection : RelationshipCollection<MaterialSpecificationCorrespondsToDefinitionRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinition>
    {
        public MaterialSpecificationCorrespondsToDefinitionRelationshipCollection(IEnumerable<MaterialSpecificationCorrespondsToDefinitionRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSpecificationCorrespondsToDefinitionRelationship>())
        {
        }
    }
}
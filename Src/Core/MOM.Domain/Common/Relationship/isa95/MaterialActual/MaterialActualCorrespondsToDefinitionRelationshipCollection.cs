namespace MOM.Domain.Common.Relationship.isa95.MaterialActual
{
    public class MaterialActualCorrespondsToDefinitionRelationshipCollection : RelationshipCollection<MaterialActualCorrespondsToDefinitionRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinition>
    {
        public MaterialActualCorrespondsToDefinitionRelationshipCollection(IEnumerable<MaterialActualCorrespondsToDefinitionRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialActualCorrespondsToDefinitionRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.MaterialDefinition
{
    public class MaterialDefinitionIsAssembledFromRelationshipCollection : RelationshipCollection<MaterialDefinitionIsAssembledFromRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinition>
    {
        public MaterialDefinitionIsAssembledFromRelationshipCollection(IEnumerable<MaterialDefinitionIsAssembledFromRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialDefinitionIsAssembledFromRelationship>())
        {
        }
    }
}
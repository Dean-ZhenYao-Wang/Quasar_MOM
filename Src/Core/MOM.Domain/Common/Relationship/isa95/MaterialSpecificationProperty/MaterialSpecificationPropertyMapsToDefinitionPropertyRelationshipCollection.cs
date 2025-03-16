namespace MOM.Domain.Common.Relationship.isa95.MaterialSpecificationProperty
{
    public class MaterialSpecificationPropertyMapsToDefinitionPropertyRelationshipCollection : RelationshipCollection<MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinitionProperty>
    {
        public MaterialSpecificationPropertyMapsToDefinitionPropertyRelationshipCollection(IEnumerable<MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship>())
        {
        }
    }
}
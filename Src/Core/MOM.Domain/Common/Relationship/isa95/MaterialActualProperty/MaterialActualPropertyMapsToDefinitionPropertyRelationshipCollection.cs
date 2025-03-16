namespace MOM.Domain.Common.Relationship.isa95.MaterialActualProperty
{
    public class MaterialActualPropertyMapsToDefinitionPropertyRelationshipCollection : RelationshipCollection<MaterialActualPropertyMapsToDefinitionPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinitionProperty>
    {
        public MaterialActualPropertyMapsToDefinitionPropertyRelationshipCollection(IEnumerable<MaterialActualPropertyMapsToDefinitionPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialActualPropertyMapsToDefinitionPropertyRelationship>())
        {
        }
    }
}
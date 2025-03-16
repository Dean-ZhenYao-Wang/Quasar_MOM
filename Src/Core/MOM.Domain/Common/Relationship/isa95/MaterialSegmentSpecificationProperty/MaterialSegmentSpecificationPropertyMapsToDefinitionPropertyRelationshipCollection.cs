namespace MOM.Domain.Common.Relationship.isa95.MaterialSegmentSpecificationProperty
{
    public class MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationshipCollection : RelationshipCollection<MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinitionProperty>
    {
        public MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationshipCollection(IEnumerable<MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship>())
        {
        }
    }
}
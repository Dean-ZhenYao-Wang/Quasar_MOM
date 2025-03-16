namespace MOM.Domain.Common.Relationship.isa95.MaterialSegmentSpecification
{
    public class MaterialSegmentSpecificationCorrespondsToDefinitionRelationshipCollection : RelationshipCollection<MaterialSegmentSpecificationCorrespondsToDefinitionRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinition>
    {
        public MaterialSegmentSpecificationCorrespondsToDefinitionRelationshipCollection(IEnumerable<MaterialSegmentSpecificationCorrespondsToDefinitionRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSegmentSpecificationCorrespondsToDefinitionRelationship>())
        {
        }
    }
}
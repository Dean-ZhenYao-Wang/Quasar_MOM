namespace MOM.Domain.Common.Relationship.isa95.MaterialSegmentSpecification
{
    public class MaterialSegmentSpecificationCorrespondsToClassRelationshipCollection : RelationshipCollection<MaterialSegmentSpecificationCorrespondsToClassRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass>
    {
        public MaterialSegmentSpecificationCorrespondsToClassRelationshipCollection(IEnumerable<MaterialSegmentSpecificationCorrespondsToClassRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSegmentSpecificationCorrespondsToClassRelationship>())
        {
        }
    }
}
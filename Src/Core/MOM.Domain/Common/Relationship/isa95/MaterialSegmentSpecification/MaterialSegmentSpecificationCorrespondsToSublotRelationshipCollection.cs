namespace MOM.Domain.Common.Relationship.isa95.MaterialSegmentSpecification
{
    public class MaterialSegmentSpecificationCorrespondsToSublotRelationshipCollection : RelationshipCollection<MaterialSegmentSpecificationCorrespondsToSublotRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot>
    {
        public MaterialSegmentSpecificationCorrespondsToSublotRelationshipCollection(IEnumerable<MaterialSegmentSpecificationCorrespondsToSublotRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSegmentSpecificationCorrespondsToSublotRelationship>())
        {
        }
    }
}
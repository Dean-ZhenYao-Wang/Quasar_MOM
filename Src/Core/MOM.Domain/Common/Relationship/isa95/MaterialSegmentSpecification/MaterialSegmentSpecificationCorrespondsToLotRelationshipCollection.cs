namespace MOM.Domain.Common.Relationship.isa95.MaterialSegmentSpecification
{
    public class MaterialSegmentSpecificationCorrespondsToLotRelationshipCollection : RelationshipCollection<MaterialSegmentSpecificationCorrespondsToLotRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot>
    {
        public MaterialSegmentSpecificationCorrespondsToLotRelationshipCollection(IEnumerable<MaterialSegmentSpecificationCorrespondsToLotRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSegmentSpecificationCorrespondsToLotRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.MaterialSpecification
{
    public class MaterialSpecificationCorrespondsToLotRelationshipCollection : RelationshipCollection<MaterialSpecificationCorrespondsToLotRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot>
    {
        public MaterialSpecificationCorrespondsToLotRelationshipCollection(IEnumerable<MaterialSpecificationCorrespondsToLotRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSpecificationCorrespondsToLotRelationship>())
        {
        }
    }
}
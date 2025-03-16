namespace MOM.Domain.Common.Relationship.isa95.MaterialLot
{
    public class MaterialLotHasValuesOfRelationshipCollection : RelationshipCollection<MaterialLotHasValuesOfRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLotProperty>
    {
        public MaterialLotHasValuesOfRelationshipCollection(IEnumerable<MaterialLotHasValuesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialLotHasValuesOfRelationship>())
        {
        }
    }
}
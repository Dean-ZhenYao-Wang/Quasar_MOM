namespace MOM.Domain.Common.Relationship.isa95.MaterialActual
{
    public class MaterialActualCorrespondsToLotRelationshipCollection : RelationshipCollection<MaterialActualCorrespondsToLotRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot>
    {
        public MaterialActualCorrespondsToLotRelationshipCollection(IEnumerable<MaterialActualCorrespondsToLotRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialActualCorrespondsToLotRelationship>())
        {
        }
    }
}
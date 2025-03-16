namespace MOM.Domain.Common.Relationship.isa95.MaterialLot
{
    public class MaterialLotIsAssembledFromSublotRelationshipCollection : RelationshipCollection<MaterialLotIsAssembledFromSublotRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot>
    {
        public MaterialLotIsAssembledFromSublotRelationshipCollection(IEnumerable<MaterialLotIsAssembledFromSublotRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialLotIsAssembledFromSublotRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.MaterialSublot
{
    public class MaterialSublotIsAssembledFromLotRelationshipCollection : RelationshipCollection<MaterialSublotIsAssembledFromLotRelationship, MOM.Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot>
    {
        public MaterialSublotIsAssembledFromLotRelationshipCollection(IEnumerable<MaterialSublotIsAssembledFromLotRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSublotIsAssembledFromLotRelationship>())
        {
        }
    }
}
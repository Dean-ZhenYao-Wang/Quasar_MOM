namespace MOM.Domain.Common.Relationship.isa95.MaterialLot
{
    public class MaterialLotIsAssembledFromRelationshipCollection : RelationshipCollection<MaterialLotIsAssembledFromRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot>
    {
        public MaterialLotIsAssembledFromRelationshipCollection(IEnumerable<MaterialLotIsAssembledFromRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialLotIsAssembledFromRelationship>())
        {
        }
    }
}
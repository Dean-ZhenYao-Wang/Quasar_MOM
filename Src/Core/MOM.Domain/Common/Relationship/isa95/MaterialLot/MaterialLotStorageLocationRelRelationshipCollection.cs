namespace MOM.Domain.Common.Relationship.isa95.MaterialLot
{
    public class MaterialLotStorageLocationRelRelationshipCollection : RelationshipCollection<MaterialLotStorageLocationRelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>
    {
        public MaterialLotStorageLocationRelRelationshipCollection(IEnumerable<MaterialLotStorageLocationRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialLotStorageLocationRelRelationship>())
        {
        }
    }
}
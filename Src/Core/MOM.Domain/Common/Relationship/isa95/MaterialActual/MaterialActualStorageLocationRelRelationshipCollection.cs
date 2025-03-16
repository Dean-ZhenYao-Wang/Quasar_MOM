namespace MOM.Domain.Common.Relationship.isa95.MaterialActual
{
    public class MaterialActualStorageLocationRelRelationshipCollection : RelationshipCollection<MaterialActualStorageLocationRelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>
    {
        public MaterialActualStorageLocationRelRelationshipCollection(IEnumerable<MaterialActualStorageLocationRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialActualStorageLocationRelRelationship>())
        {
        }
    }
}
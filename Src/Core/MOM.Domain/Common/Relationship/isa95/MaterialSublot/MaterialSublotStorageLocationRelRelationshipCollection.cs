namespace MOM.Domain.Common.Relationship.isa95.MaterialSublot
{
    public class MaterialSublotStorageLocationRelRelationshipCollection : RelationshipCollection<MaterialSublotStorageLocationRelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>
    {
        public MaterialSublotStorageLocationRelRelationshipCollection(IEnumerable<MaterialSublotStorageLocationRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSublotStorageLocationRelRelationship>())
        {
        }
    }
}
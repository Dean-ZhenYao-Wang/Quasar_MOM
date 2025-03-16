namespace MOM.Domain.Common.Relationship.isa95.MaterialSpecification
{
    public class MaterialSpecificationStorageLocationRelRelationshipCollection : RelationshipCollection<MaterialSpecificationStorageLocationRelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>
    {
        public MaterialSpecificationStorageLocationRelRelationshipCollection(IEnumerable<MaterialSpecificationStorageLocationRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSpecificationStorageLocationRelRelationship>())
        {
        }
    }
}
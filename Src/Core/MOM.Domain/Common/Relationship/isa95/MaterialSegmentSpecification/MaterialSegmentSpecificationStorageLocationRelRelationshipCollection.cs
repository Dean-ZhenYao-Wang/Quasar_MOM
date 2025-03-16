namespace MOM.Domain.Common.Relationship.isa95.MaterialSegmentSpecification
{
    public class MaterialSegmentSpecificationStorageLocationRelRelationshipCollection : RelationshipCollection<MaterialSegmentSpecificationStorageLocationRelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>
    {
        public MaterialSegmentSpecificationStorageLocationRelRelationshipCollection(IEnumerable<MaterialSegmentSpecificationStorageLocationRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSegmentSpecificationStorageLocationRelRelationship>())
        {
        }
    }
}
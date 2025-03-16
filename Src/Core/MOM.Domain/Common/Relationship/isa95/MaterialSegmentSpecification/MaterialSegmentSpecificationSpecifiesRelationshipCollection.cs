namespace MOM.Domain.Common.Relationship.isa95.MaterialSegmentSpecification
{
    public class MaterialSegmentSpecificationSpecifiesRelationshipCollection : RelationshipCollection<MaterialSegmentSpecificationSpecifiesRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification>
    {
        public MaterialSegmentSpecificationSpecifiesRelationshipCollection(IEnumerable<MaterialSegmentSpecificationSpecifiesRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSegmentSpecificationSpecifiesRelationship>())
        {
        }
    }
}
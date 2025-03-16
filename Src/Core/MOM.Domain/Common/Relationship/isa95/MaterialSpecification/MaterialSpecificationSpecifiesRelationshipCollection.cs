namespace MOM.Domain.Common.Relationship.isa95.MaterialSpecification
{
    public class MaterialSpecificationSpecifiesRelationshipCollection : RelationshipCollection<MaterialSpecificationSpecifiesRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification>
    {
        public MaterialSpecificationSpecifiesRelationshipCollection(IEnumerable<MaterialSpecificationSpecifiesRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSpecificationSpecifiesRelationship>())
        {
        }
    }
}
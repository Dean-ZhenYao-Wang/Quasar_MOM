namespace MOM.Domain.Common.Relationship.isa95.EvaluatedProperty
{
    public class EvaluatedPropertyCorrespondsToRelationshipCollection : RelationshipCollection<EvaluatedPropertyCorrespondsToRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestableObjectProperty>
    {
        public EvaluatedPropertyCorrespondsToRelationshipCollection(IEnumerable<EvaluatedPropertyCorrespondsToRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EvaluatedPropertyCorrespondsToRelationship>())
        {
        }
    }
}
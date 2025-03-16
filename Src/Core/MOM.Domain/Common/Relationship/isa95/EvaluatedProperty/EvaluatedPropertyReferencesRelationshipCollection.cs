namespace MOM.Domain.Common.Relationship.isa95.EvaluatedProperty
{
    public class EvaluatedPropertyReferencesRelationshipCollection : RelationshipCollection<EvaluatedPropertyReferencesRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecificationCriteria>
    {
        public EvaluatedPropertyReferencesRelationshipCollection(IEnumerable<EvaluatedPropertyReferencesRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EvaluatedPropertyReferencesRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.OperationsTestRequirement
{
    public class OperationsTestRequirementSpecifiesRelationshipCollection : RelationshipCollection<OperationsTestRequirementSpecifiesRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification>
    {
        public OperationsTestRequirementSpecifiesRelationshipCollection(IEnumerable<OperationsTestRequirementSpecifiesRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsTestRequirementSpecifiesRelationship>())
        {
        }
    }
}
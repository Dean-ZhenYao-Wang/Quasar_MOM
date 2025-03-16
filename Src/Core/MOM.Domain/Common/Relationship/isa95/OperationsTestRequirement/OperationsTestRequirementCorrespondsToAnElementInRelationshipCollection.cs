namespace MOM.Domain.Common.Relationship.isa95.OperationsTestRequirement
{
    public class OperationsTestRequirementCorrespondsToAnElementInRelationshipCollection : RelationshipCollection<OperationsTestRequirementCorrespondsToAnElementInRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestableObject>
    {
        public OperationsTestRequirementCorrespondsToAnElementInRelationshipCollection(IEnumerable<OperationsTestRequirementCorrespondsToAnElementInRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsTestRequirementCorrespondsToAnElementInRelationship>())
        {
        }
    }
}
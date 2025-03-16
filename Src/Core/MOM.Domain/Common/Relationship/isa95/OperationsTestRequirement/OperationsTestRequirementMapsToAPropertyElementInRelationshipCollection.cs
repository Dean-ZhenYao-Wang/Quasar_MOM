namespace MOM.Domain.Common.Relationship.isa95.OperationsTestRequirement
{
    public class OperationsTestRequirementMapsToAPropertyElementInRelationshipCollection : RelationshipCollection<OperationsTestRequirementMapsToAPropertyElementInRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestableObjectProperty>
    {
        public OperationsTestRequirementMapsToAPropertyElementInRelationshipCollection(IEnumerable<OperationsTestRequirementMapsToAPropertyElementInRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsTestRequirementMapsToAPropertyElementInRelationship>())
        {
        }
    }
}
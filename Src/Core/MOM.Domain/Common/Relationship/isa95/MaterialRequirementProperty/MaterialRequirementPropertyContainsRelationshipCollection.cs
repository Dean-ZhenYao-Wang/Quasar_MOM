namespace MOM.Domain.Common.Relationship.isa95.MaterialRequirementProperty
{
    public class MaterialRequirementPropertyContainsRelationshipCollection : RelationshipCollection<MaterialRequirementPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirementProperty>
    {
        public MaterialRequirementPropertyContainsRelationshipCollection(IEnumerable<MaterialRequirementPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialRequirementPropertyContainsRelationship>())
        {
        }
    }
}
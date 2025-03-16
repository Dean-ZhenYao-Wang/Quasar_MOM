namespace MOM.Domain.Common.Relationship.isa95.MaterialRequirement
{
    public class MaterialRequirementContainsRelationshipCollection : RelationshipCollection<MaterialRequirementContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirement>
    {
        public MaterialRequirementContainsRelationshipCollection(IEnumerable<MaterialRequirementContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialRequirementContainsRelationship>())
        {
        }
    }
}
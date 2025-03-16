namespace MOM.Domain.Common.Relationship.isa95.MaterialRequirement
{
    public class MaterialRequirementHasValuesOfRelationshipCollection : RelationshipCollection<MaterialRequirementHasValuesOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirementProperty>
    {
        public MaterialRequirementHasValuesOfRelationshipCollection(IEnumerable<MaterialRequirementHasValuesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialRequirementHasValuesOfRelationship>())
        {
        }
    }
}
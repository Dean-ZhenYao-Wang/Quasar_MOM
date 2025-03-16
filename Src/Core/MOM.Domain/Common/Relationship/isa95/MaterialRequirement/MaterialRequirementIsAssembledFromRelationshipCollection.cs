namespace MOM.Domain.Common.Relationship.isa95.MaterialRequirement
{
    public class MaterialRequirementIsAssembledFromRelationshipCollection : RelationshipCollection<MaterialRequirementIsAssembledFromRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirement>
    {
        public MaterialRequirementIsAssembledFromRelationshipCollection(IEnumerable<MaterialRequirementIsAssembledFromRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialRequirementIsAssembledFromRelationship>())
        {
        }
    }
}
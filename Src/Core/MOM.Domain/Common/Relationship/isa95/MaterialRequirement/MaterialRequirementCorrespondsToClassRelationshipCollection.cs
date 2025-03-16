namespace MOM.Domain.Common.Relationship.isa95.MaterialRequirement
{
    public class MaterialRequirementCorrespondsToClassRelationshipCollection : RelationshipCollection<MaterialRequirementCorrespondsToClassRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass>
    {
        public MaterialRequirementCorrespondsToClassRelationshipCollection(IEnumerable<MaterialRequirementCorrespondsToClassRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialRequirementCorrespondsToClassRelationship>())
        {
        }
    }
}
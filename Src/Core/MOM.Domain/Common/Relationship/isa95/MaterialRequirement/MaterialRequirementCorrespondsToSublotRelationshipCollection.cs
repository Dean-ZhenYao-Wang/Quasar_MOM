namespace MOM.Domain.Common.Relationship.isa95.MaterialRequirement
{
    public class MaterialRequirementCorrespondsToSublotRelationshipCollection : RelationshipCollection<MaterialRequirementCorrespondsToSublotRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot>
    {
        public MaterialRequirementCorrespondsToSublotRelationshipCollection(IEnumerable<MaterialRequirementCorrespondsToSublotRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialRequirementCorrespondsToSublotRelationship>())
        {
        }
    }
}
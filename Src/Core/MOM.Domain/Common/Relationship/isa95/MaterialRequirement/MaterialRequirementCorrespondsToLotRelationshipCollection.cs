namespace MOM.Domain.Common.Relationship.isa95.MaterialRequirement
{
    public class MaterialRequirementCorrespondsToLotRelationshipCollection : RelationshipCollection<MaterialRequirementCorrespondsToLotRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLot>
    {
        public MaterialRequirementCorrespondsToLotRelationshipCollection(IEnumerable<MaterialRequirementCorrespondsToLotRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialRequirementCorrespondsToLotRelationship>())
        {
        }
    }
}
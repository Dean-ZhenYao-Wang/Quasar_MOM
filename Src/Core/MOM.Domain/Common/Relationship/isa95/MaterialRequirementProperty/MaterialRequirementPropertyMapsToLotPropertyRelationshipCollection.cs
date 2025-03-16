namespace MOM.Domain.Common.Relationship.isa95.MaterialRequirementProperty
{
    public class MaterialRequirementPropertyMapsToLotPropertyRelationshipCollection : RelationshipCollection<MaterialRequirementPropertyMapsToLotPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLotProperty>
    {
        public MaterialRequirementPropertyMapsToLotPropertyRelationshipCollection(IEnumerable<MaterialRequirementPropertyMapsToLotPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialRequirementPropertyMapsToLotPropertyRelationship>())
        {
        }
    }
}
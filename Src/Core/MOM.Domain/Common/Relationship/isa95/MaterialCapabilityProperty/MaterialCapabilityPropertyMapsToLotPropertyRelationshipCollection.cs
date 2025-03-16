namespace MOM.Domain.Common.Relationship.isa95.MaterialCapabilityProperty
{
    public class MaterialCapabilityPropertyMapsToLotPropertyRelationshipCollection : RelationshipCollection<MaterialCapabilityPropertyMapsToLotPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLotProperty>
    {
        public MaterialCapabilityPropertyMapsToLotPropertyRelationshipCollection(IEnumerable<MaterialCapabilityPropertyMapsToLotPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialCapabilityPropertyMapsToLotPropertyRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.MaterialActualProperty
{
    public class MaterialActualPropertyMapsToLotPropertyRelationshipCollection : RelationshipCollection<MaterialActualPropertyMapsToLotPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLotProperty>
    {
        public MaterialActualPropertyMapsToLotPropertyRelationshipCollection(IEnumerable<MaterialActualPropertyMapsToLotPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialActualPropertyMapsToLotPropertyRelationship>())
        {
        }
    }
}
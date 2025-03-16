namespace MOM.Domain.Common.Relationship.isa95.MaterialLotProperty
{
    public class MaterialLotPropertyMapsToRelationshipCollection : RelationshipCollection<MaterialLotPropertyMapsToRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialDefinitionProperty>
    {
        public MaterialLotPropertyMapsToRelationshipCollection(IEnumerable<MaterialLotPropertyMapsToRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialLotPropertyMapsToRelationship>())
        {
        }
    }
}
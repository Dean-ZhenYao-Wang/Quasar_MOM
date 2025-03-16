namespace MOM.Domain.Common.Relationship.isa95.MaterialSpecificationProperty
{
    public class MaterialSpecificationPropertyMapsToLotPropertyRelationshipCollection : RelationshipCollection<MaterialSpecificationPropertyMapsToLotPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLotProperty>
    {
        public MaterialSpecificationPropertyMapsToLotPropertyRelationshipCollection(IEnumerable<MaterialSpecificationPropertyMapsToLotPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSpecificationPropertyMapsToLotPropertyRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.MaterialActualProperty
{
    public class MaterialActualPropertyMapsToClassPropertyRelationshipCollection : RelationshipCollection<MaterialActualPropertyMapsToClassPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClassProperty>
    {
        public MaterialActualPropertyMapsToClassPropertyRelationshipCollection(IEnumerable<MaterialActualPropertyMapsToClassPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialActualPropertyMapsToClassPropertyRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.MaterialClass
{
    public class MaterialClassHasPropertiesOfRelationshipCollection : RelationshipCollection<MaterialClassHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClassProperty>
    {
        public MaterialClassHasPropertiesOfRelationshipCollection(IEnumerable<MaterialClassHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialClassHasPropertiesOfRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.MaterialClass
{
    public class MaterialClassIncludesPropertiesOfRelationshipCollection : RelationshipCollection<MaterialClassIncludesPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass>
    {
        public MaterialClassIncludesPropertiesOfRelationshipCollection(IEnumerable<MaterialClassIncludesPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialClassIncludesPropertiesOfRelationship>())
        {
        }
    }
}
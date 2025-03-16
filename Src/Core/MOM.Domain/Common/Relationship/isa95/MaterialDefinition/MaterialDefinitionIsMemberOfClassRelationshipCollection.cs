namespace MOM.Domain.Common.Relationship.isa95.MaterialDefinition
{
    public class MaterialDefinitionIsMemberOfClassRelationshipCollection : RelationshipCollection<MaterialDefinitionIsMemberOfClassRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass>
    {
        public MaterialDefinitionIsMemberOfClassRelationshipCollection(IEnumerable<MaterialDefinitionIsMemberOfClassRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialDefinitionIsMemberOfClassRelationship>())
        {
        }
    }
}
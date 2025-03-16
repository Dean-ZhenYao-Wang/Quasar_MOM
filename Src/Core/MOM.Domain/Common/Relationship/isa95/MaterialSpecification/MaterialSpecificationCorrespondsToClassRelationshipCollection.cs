namespace MOM.Domain.Common.Relationship.isa95.MaterialSpecification
{
    public class MaterialSpecificationCorrespondsToClassRelationshipCollection : RelationshipCollection<MaterialSpecificationCorrespondsToClassRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass>
    {
        public MaterialSpecificationCorrespondsToClassRelationshipCollection(IEnumerable<MaterialSpecificationCorrespondsToClassRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSpecificationCorrespondsToClassRelationship>())
        {
        }
    }
}
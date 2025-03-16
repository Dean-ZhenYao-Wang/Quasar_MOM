namespace MOM.Domain.Common.Relationship.isa95.MaterialSpecification
{
    public class MaterialSpecificationCorrespondsToSublotRelationshipCollection : RelationshipCollection<MaterialSpecificationCorrespondsToSublotRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot>
    {
        public MaterialSpecificationCorrespondsToSublotRelationshipCollection(IEnumerable<MaterialSpecificationCorrespondsToSublotRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSpecificationCorrespondsToSublotRelationship>())
        {
        }
    }
}
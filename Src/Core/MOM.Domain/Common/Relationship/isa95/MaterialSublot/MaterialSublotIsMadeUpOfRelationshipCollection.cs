namespace MOM.Domain.Common.Relationship.isa95.MaterialSublot
{
    public class MaterialSublotIsMadeUpOfRelationshipCollection : RelationshipCollection<MaterialSublotIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot>
    {
        public MaterialSublotIsMadeUpOfRelationshipCollection(IEnumerable<MaterialSublotIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSublotIsMadeUpOfRelationship>())
        {
        }
    }
}
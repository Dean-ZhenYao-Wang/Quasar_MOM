namespace MOM.Domain.Common.Relationship.isa95.MaterialSublot
{
    public class MaterialSublotIsAssembledFromRelationshipCollection : RelationshipCollection<MaterialSublotIsAssembledFromRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot>
    {
        public MaterialSublotIsAssembledFromRelationshipCollection(IEnumerable<MaterialSublotIsAssembledFromRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSublotIsAssembledFromRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.MaterialActual
{
    public class MaterialActualCorrespondsToSublotRelationshipCollection : RelationshipCollection<MaterialActualCorrespondsToSublotRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialSublot>
    {
        public MaterialActualCorrespondsToSublotRelationshipCollection(IEnumerable<MaterialActualCorrespondsToSublotRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialActualCorrespondsToSublotRelationship>())
        {
        }
    }
}
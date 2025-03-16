namespace MOM.Domain.Common.Relationship.isa95.MaterialSublot
{
    public class MaterialSublotHasValuesOfRelationshipCollection : RelationshipCollection<MaterialSublotHasValuesOfRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLotProperty>
    {
        public MaterialSublotHasValuesOfRelationshipCollection(IEnumerable<MaterialSublotHasValuesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSublotHasValuesOfRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.MaterialActual
{
    public class MaterialActualCorrespondsToClassRelationshipCollection : RelationshipCollection<MaterialActualCorrespondsToClassRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass>
    {
        public MaterialActualCorrespondsToClassRelationshipCollection(IEnumerable<MaterialActualCorrespondsToClassRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialActualCorrespondsToClassRelationship>())
        {
        }
    }
}
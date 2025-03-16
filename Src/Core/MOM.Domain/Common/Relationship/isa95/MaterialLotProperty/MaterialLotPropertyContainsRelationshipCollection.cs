namespace MOM.Domain.Common.Relationship.isa95.MaterialLotProperty
{
    public class MaterialLotPropertyContainsRelationshipCollection : RelationshipCollection<MaterialLotPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialLotProperty>
    {
        public MaterialLotPropertyContainsRelationshipCollection(IEnumerable<MaterialLotPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialLotPropertyContainsRelationship>())
        {
        }
    }
}
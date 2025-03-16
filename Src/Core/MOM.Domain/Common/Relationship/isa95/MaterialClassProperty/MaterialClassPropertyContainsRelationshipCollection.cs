namespace MOM.Domain.Common.Relationship.isa95.MaterialClassProperty
{
    public class MaterialClassPropertyContainsRelationshipCollection : RelationshipCollection<MaterialClassPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClassProperty>
    {
        public MaterialClassPropertyContainsRelationshipCollection(IEnumerable<MaterialClassPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialClassPropertyContainsRelationship>())
        {
        }
    }
}
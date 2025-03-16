namespace MOM.Domain.Common.Relationship.isa95.MaterialClass
{
    public class MaterialClassIsAssembledFromRelationshipCollection : RelationshipCollection<MaterialClassIsAssembledFromRelationship, Domain.isa95.CommonObjectModels.Part2.Material.MaterialClass>
    {
        public MaterialClassIsAssembledFromRelationshipCollection(IEnumerable<MaterialClassIsAssembledFromRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialClassIsAssembledFromRelationship>())
        {
        }
    }
}
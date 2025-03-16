namespace MOM.Domain.Common.Relationship.isa95.MaterialActualProperty
{
    public class MaterialActualPropertyContainsRelationshipCollection : RelationshipCollection<MaterialActualPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActualProperty>
    {
        public MaterialActualPropertyContainsRelationshipCollection(IEnumerable<MaterialActualPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialActualPropertyContainsRelationship>())
        {
        }
    }
}
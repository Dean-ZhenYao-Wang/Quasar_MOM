namespace MOM.Domain.Common.Relationship.isa95.MaterialActual
{
    public class MaterialActualHasValuesOfRelationshipCollection : RelationshipCollection<MaterialActualHasValuesOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActualProperty>
    {
        public MaterialActualHasValuesOfRelationshipCollection(IEnumerable<MaterialActualHasValuesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialActualHasValuesOfRelationship>())
        {
        }
    }
}
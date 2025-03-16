namespace MOM.Domain.Common.Relationship.isa95.MaterialActual
{
    public class MaterialActualIsAssembledFromRelationshipCollection : RelationshipCollection<MaterialActualIsAssembledFromRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.MaterialActual>
    {
        public MaterialActualIsAssembledFromRelationshipCollection(IEnumerable<MaterialActualIsAssembledFromRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialActualIsAssembledFromRelationship>())
        {
        }
    }
}
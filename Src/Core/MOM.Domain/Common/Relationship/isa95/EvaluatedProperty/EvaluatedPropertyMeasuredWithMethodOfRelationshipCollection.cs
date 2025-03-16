namespace MOM.Domain.Common.Relationship.isa95.EvaluatedProperty
{
    public class EvaluatedPropertyMeasuredWithMethodOfRelationshipCollection : RelationshipCollection<EvaluatedPropertyMeasuredWithMethodOfRelationship, Domain.isa95.CommonObjectModels.Part4.WorkDefinition.WorkDefinition>
    {
        public EvaluatedPropertyMeasuredWithMethodOfRelationshipCollection(IEnumerable<EvaluatedPropertyMeasuredWithMethodOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<EvaluatedPropertyMeasuredWithMethodOfRelationship>())
        {
        }
    }
}
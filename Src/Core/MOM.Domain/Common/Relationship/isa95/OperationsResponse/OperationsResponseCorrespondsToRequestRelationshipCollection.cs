namespace MOM.Domain.Common.Relationship.isa95.OperationsResponse
{
    public class OperationsResponseCorrespondsToRequestRelationshipCollection : RelationshipCollection<OperationsResponseCorrespondsToRequestRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.OperationsRequest>
    {
        public OperationsResponseCorrespondsToRequestRelationshipCollection(IEnumerable<OperationsResponseCorrespondsToRequestRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsResponseCorrespondsToRequestRelationship>())
        {
        }
    }
}
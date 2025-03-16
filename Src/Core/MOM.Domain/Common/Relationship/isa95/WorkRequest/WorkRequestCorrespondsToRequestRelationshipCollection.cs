namespace MOM.Domain.Common.Relationship.isa95.WorkRequest
{
    public class WorkRequestCorrespondsToRequestRelationshipCollection : RelationshipCollection<WorkRequestCorrespondsToRequestRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.OperationsRequest>
    {
        public WorkRequestCorrespondsToRequestRelationshipCollection(IEnumerable<WorkRequestCorrespondsToRequestRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkRequestCorrespondsToRequestRelationship>())
        {
        }
    }
}
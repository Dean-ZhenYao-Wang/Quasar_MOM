namespace MOM.Domain.Common.Relationship.isa95.WorkRequest
{
    public class WorkRequestIsMadeUpOfRequestRelationshipCollection : RelationshipCollection<WorkRequestIsMadeUpOfRequestRelationship, Domain.isa95.CommonObjectModels.Part4.WorkSchedule.WorkRequest>
    {
        public WorkRequestIsMadeUpOfRequestRelationshipCollection(IEnumerable<WorkRequestIsMadeUpOfRequestRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkRequestIsMadeUpOfRequestRelationship>())
        {
        }
    }
}
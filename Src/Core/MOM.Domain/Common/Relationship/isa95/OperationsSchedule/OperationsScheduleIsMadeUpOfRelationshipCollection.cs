namespace MOM.Domain.Common.Relationship.isa95.OperationsSchedule
{
    public class OperationsScheduleIsMadeUpOfRelationshipCollection : RelationshipCollection<OperationsScheduleIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.OperationsRequest>
    {
        public OperationsScheduleIsMadeUpOfRelationshipCollection(IEnumerable<OperationsScheduleIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<OperationsScheduleIsMadeUpOfRelationship>())
        {
        }
    }
}
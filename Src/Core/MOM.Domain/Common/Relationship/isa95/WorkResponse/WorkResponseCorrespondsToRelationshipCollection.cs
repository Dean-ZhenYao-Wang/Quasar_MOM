namespace MOM.Domain.Common.Relationship.isa95.WorkResponse
{
    public class WorkResponseCorrespondsToRelationshipCollection : RelationshipCollection<WorkResponseCorrespondsToRelationship, Domain.isa95.CommonObjectModels.Part4.WorkSchedule.WorkRequest>
    {
        public WorkResponseCorrespondsToRelationshipCollection(IEnumerable<WorkResponseCorrespondsToRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkResponseCorrespondsToRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.WorkResponse
{
    public class WorkResponseIsMadeUpOfResponseRelationshipCollection : RelationshipCollection<WorkResponseIsMadeUpOfResponseRelationship, Domain.isa95.CommonObjectModels.Part4.WorkPerformance.WorkResponse>
    {
        public WorkResponseIsMadeUpOfResponseRelationshipCollection(IEnumerable<WorkResponseIsMadeUpOfResponseRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkResponseIsMadeUpOfResponseRelationship>())
        {
        }
    }
}
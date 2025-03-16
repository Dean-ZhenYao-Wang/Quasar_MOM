namespace MOM.Domain.Common.Relationship.isa95.JobOrder
{
    public class JobOrderContainsMaterialRelationshipCollection : RelationshipCollection<JobOrderContainsMaterialRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.MaterialRequirement>
    {
        public JobOrderContainsMaterialRelationshipCollection(IEnumerable<JobOrderContainsMaterialRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobOrderContainsMaterialRelationship>())
        {
        }
    }
}
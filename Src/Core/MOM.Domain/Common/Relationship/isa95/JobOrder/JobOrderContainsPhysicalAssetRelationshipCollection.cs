namespace MOM.Domain.Common.Relationship.isa95.JobOrder
{
    public class JobOrderContainsPhysicalAssetRelationshipCollection : RelationshipCollection<JobOrderContainsPhysicalAssetRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PhysicalAssetRequirement>
    {
        public JobOrderContainsPhysicalAssetRelationshipCollection(IEnumerable<JobOrderContainsPhysicalAssetRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobOrderContainsPhysicalAssetRelationship>())
        {
        }
    }
}
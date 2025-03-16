namespace MOM.Domain.Common.Relationship.isa95.JobResponse
{
    public class JobResponseContainsPhysicalAssetRelationshipCollection : RelationshipCollection<JobResponseContainsPhysicalAssetRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PhysicalAssetActual>
    {
        public JobResponseContainsPhysicalAssetRelationshipCollection(IEnumerable<JobResponseContainsPhysicalAssetRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobResponseContainsPhysicalAssetRelationship>())
        {
        }
    }
}
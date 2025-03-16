namespace MOM.Domain.Common.Relationship.isa95.JobResponse
{
    public class JobResponseContainsEquipmentRelationshipCollection : RelationshipCollection<JobResponseContainsEquipmentRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.EquipmentActual>
    {
        public JobResponseContainsEquipmentRelationshipCollection(IEnumerable<JobResponseContainsEquipmentRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobResponseContainsEquipmentRelationship>())
        {
        }
    }
}
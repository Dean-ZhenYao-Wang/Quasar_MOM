namespace MOM.Domain.Common.Relationship.isa95.JobOrder
{
    public class JobOrderContainsEquipmentRelationshipCollection : RelationshipCollection<JobOrderContainsEquipmentRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.EquipmentRequirement>
    {
        public JobOrderContainsEquipmentRelationshipCollection(IEnumerable<JobOrderContainsEquipmentRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobOrderContainsEquipmentRelationship>())
        {
        }
    }
}
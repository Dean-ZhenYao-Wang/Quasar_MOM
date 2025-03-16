namespace MOM.Domain.Common.Relationship.isa95.WorkMaster
{
    public class WorkMasterCorrespondsToProcessRelationshipCollection : RelationshipCollection<WorkMasterCorrespondsToProcessRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.ProcessSegment>
    {
        public WorkMasterCorrespondsToProcessRelationshipCollection(IEnumerable<WorkMasterCorrespondsToProcessRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkMasterCorrespondsToProcessRelationship>())
        {
        }
    }
}
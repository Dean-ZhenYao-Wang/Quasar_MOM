namespace MOM.Domain.Common.Relationship.isa95.WorkMaster
{
    public class WorkMasterCorrespondsToOperationsRelationshipCollection : RelationshipCollection<WorkMasterCorrespondsToOperationsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsSegment>
    {
        public WorkMasterCorrespondsToOperationsRelationshipCollection(IEnumerable<WorkMasterCorrespondsToOperationsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkMasterCorrespondsToOperationsRelationship>())
        {
        }
    }
}
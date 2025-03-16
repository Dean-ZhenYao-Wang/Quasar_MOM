namespace MOM.Domain.Common.Relationship.isa95.WorkMaster
{
    public class WorkMasterCorrespondsToDefinitionRelationshipCollection : RelationshipCollection<WorkMasterCorrespondsToDefinitionRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.OperationsDefinition>
    {
        public WorkMasterCorrespondsToDefinitionRelationshipCollection(IEnumerable<WorkMasterCorrespondsToDefinitionRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkMasterCorrespondsToDefinitionRelationship>())
        {
        }
    }
}
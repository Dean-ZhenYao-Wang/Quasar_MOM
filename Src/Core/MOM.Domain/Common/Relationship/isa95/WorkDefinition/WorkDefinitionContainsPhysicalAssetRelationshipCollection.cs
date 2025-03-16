namespace MOM.Domain.Common.Relationship.isa95.WorkDefinition
{
    public class WorkDefinitionContainsPhysicalAssetRelationshipCollection : RelationshipCollection<WorkDefinitionContainsPhysicalAssetRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PhysicalAssetSpecification>
    {
        public WorkDefinitionContainsPhysicalAssetRelationshipCollection(IEnumerable<WorkDefinitionContainsPhysicalAssetRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkDefinitionContainsPhysicalAssetRelationship>())
        {
        }
    }
}
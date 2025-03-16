namespace MOM.Domain.Common.Relationship.isa95.WorkDefinition
{
    public class WorkDefinitionContainsMaterialRelationshipCollection : RelationshipCollection<WorkDefinitionContainsMaterialRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecification>
    {
        public WorkDefinitionContainsMaterialRelationshipCollection(IEnumerable<WorkDefinitionContainsMaterialRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkDefinitionContainsMaterialRelationship>())
        {
        }
    }
}
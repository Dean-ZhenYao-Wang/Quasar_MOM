namespace MOM.Domain.Common.Relationship.isa95.WorkDefinition
{
    public class WorkDefinitionContainsParameterRelationshipCollection : RelationshipCollection<WorkDefinitionContainsParameterRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.ParameterSpecification>
    {
        public WorkDefinitionContainsParameterRelationshipCollection(IEnumerable<WorkDefinitionContainsParameterRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkDefinitionContainsParameterRelationship>())
        {
        }
    }
}
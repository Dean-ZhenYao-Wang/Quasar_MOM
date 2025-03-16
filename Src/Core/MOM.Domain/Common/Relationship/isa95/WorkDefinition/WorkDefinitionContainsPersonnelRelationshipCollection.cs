namespace MOM.Domain.Common.Relationship.isa95.WorkDefinition
{
    public class WorkDefinitionContainsPersonnelRelationshipCollection : RelationshipCollection<WorkDefinitionContainsPersonnelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PersonnelSpecification>
    {
        public WorkDefinitionContainsPersonnelRelationshipCollection(IEnumerable<WorkDefinitionContainsPersonnelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkDefinitionContainsPersonnelRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.WorkDefinition
{
    public class WorkDefinitionContainsEquipmentRelationshipCollection : RelationshipCollection<WorkDefinitionContainsEquipmentRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.EquipmentSpecification>
    {
        public WorkDefinitionContainsEquipmentRelationshipCollection(IEnumerable<WorkDefinitionContainsEquipmentRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkDefinitionContainsEquipmentRelationship>())
        {
        }
    }
}
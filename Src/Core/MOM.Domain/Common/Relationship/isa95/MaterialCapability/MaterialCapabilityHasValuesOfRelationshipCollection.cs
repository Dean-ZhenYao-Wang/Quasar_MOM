namespace MOM.Domain.Common.Relationship.isa95.MaterialCapability
{
    public class MaterialCapabilityHasValuesOfRelationshipCollection : RelationshipCollection<MaterialCapabilityHasValuesOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecificationProperty>
    {
        public MaterialCapabilityHasValuesOfRelationshipCollection(IEnumerable<MaterialCapabilityHasValuesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialCapabilityHasValuesOfRelationship>())
        {
        }
    }
}
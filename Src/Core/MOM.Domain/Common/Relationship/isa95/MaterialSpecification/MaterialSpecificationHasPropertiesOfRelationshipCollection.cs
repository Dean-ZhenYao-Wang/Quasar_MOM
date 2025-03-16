namespace MOM.Domain.Common.Relationship.isa95.MaterialSpecification
{
    public class MaterialSpecificationHasPropertiesOfRelationshipCollection : RelationshipCollection<MaterialSpecificationHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecificationProperty>
    {
        public MaterialSpecificationHasPropertiesOfRelationshipCollection(IEnumerable<MaterialSpecificationHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSpecificationHasPropertiesOfRelationship>())
        {
        }
    }
}
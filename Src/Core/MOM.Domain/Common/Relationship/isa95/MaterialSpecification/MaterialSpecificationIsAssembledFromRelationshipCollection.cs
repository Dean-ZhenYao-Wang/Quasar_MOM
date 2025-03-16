namespace MOM.Domain.Common.Relationship.isa95.MaterialSpecification
{
    public class MaterialSpecificationIsAssembledFromRelationshipCollection : RelationshipCollection<MaterialSpecificationIsAssembledFromRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.MaterialSpecification>
    {
        public MaterialSpecificationIsAssembledFromRelationshipCollection(IEnumerable<MaterialSpecificationIsAssembledFromRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<MaterialSpecificationIsAssembledFromRelationship>())
        {
        }
    }
}
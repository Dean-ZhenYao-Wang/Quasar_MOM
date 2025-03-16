namespace MOM.Domain.Common.Relationship.isa95.ParameterSpecification
{
    public class ParameterSpecificationContainsRelationshipCollection : RelationshipCollection<ParameterSpecificationContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.ParameterSpecification>
    {
        public ParameterSpecificationContainsRelationshipCollection(IEnumerable<ParameterSpecificationContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ParameterSpecificationContainsRelationship>())
        {
        }
    }
}
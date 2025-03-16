namespace MOM.Domain.Common.Relationship.isa95.JobOrderParameter
{
    public class JobOrderParameterCorrespondsToSpecificationRelationshipCollection : RelationshipCollection<JobOrderParameterCorrespondsToSpecificationRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.ParameterSpecification>
    {
        public JobOrderParameterCorrespondsToSpecificationRelationshipCollection(IEnumerable<JobOrderParameterCorrespondsToSpecificationRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<JobOrderParameterCorrespondsToSpecificationRelationship>())
        {
        }
    }
}
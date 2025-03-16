namespace MOM.Domain.Common.Relationship.isa95.SegmentParameter
{
    public class SegmentParameterCorrespondsToSpecificationRelationshipCollection : RelationshipCollection<SegmentParameterCorrespondsToSpecificationRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.ParameterSpecification>
    {
        public SegmentParameterCorrespondsToSpecificationRelationshipCollection(IEnumerable<SegmentParameterCorrespondsToSpecificationRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<SegmentParameterCorrespondsToSpecificationRelationship>())
        {
        }
    }
}
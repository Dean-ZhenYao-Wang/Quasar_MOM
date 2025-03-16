namespace MOM.Domain.Common.Relationship.isa95.ProcessSegment
{
    public class ProcessSegmentContainsMaterialSpecificationRelationshipCollection : RelationshipCollection<ProcessSegmentContainsMaterialSpecificationRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.MaterialSegmentSpecification>
    {
        public ProcessSegmentContainsMaterialSpecificationRelationshipCollection(IEnumerable<ProcessSegmentContainsMaterialSpecificationRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ProcessSegmentContainsMaterialSpecificationRelationship>())
        {
        }
    }
}
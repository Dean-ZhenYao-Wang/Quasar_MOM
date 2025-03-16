namespace MOM.Domain.Common.Relationship.isa95.ProcessSegment
{
    public class ProcessSegmentContainsPersonnelSpecificationRelationshipCollection : RelationshipCollection<ProcessSegmentContainsPersonnelSpecificationRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PersonnelSegmentSpecification>
    {
        public ProcessSegmentContainsPersonnelSpecificationRelationshipCollection(IEnumerable<ProcessSegmentContainsPersonnelSpecificationRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<ProcessSegmentContainsPersonnelSpecificationRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.PersonnelSegmentSpecification
{
    public class PersonnelSegmentSpecificationIsMadeUpOfRelationshipCollection : RelationshipCollection<PersonnelSegmentSpecificationIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PersonnelSegmentSpecification>
    {
        public PersonnelSegmentSpecificationIsMadeUpOfRelationshipCollection(IEnumerable<PersonnelSegmentSpecificationIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelSegmentSpecificationIsMadeUpOfRelationship>())
        {
        }
    }
}
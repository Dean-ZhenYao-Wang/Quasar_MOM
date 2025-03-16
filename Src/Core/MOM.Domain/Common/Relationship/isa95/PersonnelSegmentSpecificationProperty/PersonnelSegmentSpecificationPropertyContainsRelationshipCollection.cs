namespace MOM.Domain.Common.Relationship.isa95.PersonnelSegmentSpecificationProperty
{
    public class PersonnelSegmentSpecificationPropertyContainsRelationshipCollection : RelationshipCollection<PersonnelSegmentSpecificationPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PersonnelSegmentSpecificationProperty>
    {
        public PersonnelSegmentSpecificationPropertyContainsRelationshipCollection(IEnumerable<PersonnelSegmentSpecificationPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelSegmentSpecificationPropertyContainsRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.PersonnelSegmentSpecification
{
    public class PersonnelSegmentSpecificationSpecifiesRelationshipCollection : RelationshipCollection<PersonnelSegmentSpecificationSpecifiesRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification>
    {
        public PersonnelSegmentSpecificationSpecifiesRelationshipCollection(IEnumerable<PersonnelSegmentSpecificationSpecifiesRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelSegmentSpecificationSpecifiesRelationship>())
        {
        }
    }
}
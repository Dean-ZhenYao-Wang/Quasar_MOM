namespace MOM.Domain.Common.Relationship.isa95.PersonnelSpecification
{
    public class PersonnelSpecificationSpecifiesRelationshipCollection : RelationshipCollection<PersonnelSpecificationSpecifiesRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsTest.TestSpecification>
    {
        public PersonnelSpecificationSpecifiesRelationshipCollection(IEnumerable<PersonnelSpecificationSpecifiesRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelSpecificationSpecifiesRelationship>())
        {
        }
    }
}
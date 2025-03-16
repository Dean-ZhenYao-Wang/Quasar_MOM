namespace MOM.Domain.Common.Relationship.isa95.Person
{
    public class PersonHasValuesOfRelationshipCollection : RelationshipCollection<PersonHasValuesOfRelationship, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonProperty>
    {
        public PersonHasValuesOfRelationshipCollection(IEnumerable<PersonHasValuesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonHasValuesOfRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.PersonProperty
{
    public class PersonPropertyContainsRelationshipCollection : RelationshipCollection<PersonPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonProperty>
    {
        public PersonPropertyContainsRelationshipCollection(IEnumerable<PersonPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonPropertyContainsRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.Person
{
    public class PersonOperationalLocationRelRelationshipCollection : RelationshipCollection<PersonOperationalLocationRelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>
    {
        public PersonOperationalLocationRelRelationshipCollection(IEnumerable<PersonOperationalLocationRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonOperationalLocationRelRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.Person
{
    public class PersonDefinedByRelationshipCollection : RelationshipCollection<PersonDefinedByRelationship, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass>
    {
        public PersonDefinedByRelationshipCollection(IEnumerable<PersonDefinedByRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonDefinedByRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.PersonnelActual
{
    public class PersonnelActualOperationalLocationRelRelationshipCollection : RelationshipCollection<PersonnelActualOperationalLocationRelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>
    {
        public PersonnelActualOperationalLocationRelRelationshipCollection(IEnumerable<PersonnelActualOperationalLocationRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelActualOperationalLocationRelRelationship>())
        {
        }
    }
}
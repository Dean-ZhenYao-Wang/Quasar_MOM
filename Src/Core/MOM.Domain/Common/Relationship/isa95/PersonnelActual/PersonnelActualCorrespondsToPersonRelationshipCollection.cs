namespace MOM.Domain.Common.Relationship.isa95.PersonnelActual
{
    public class PersonnelActualCorrespondsToPersonRelationshipCollection : RelationshipCollection<PersonnelActualCorrespondsToPersonRelationship, Domain.isa95.CommonObjectModels.Part2.Personnel.Person>
    {
        public PersonnelActualCorrespondsToPersonRelationshipCollection(IEnumerable<PersonnelActualCorrespondsToPersonRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelActualCorrespondsToPersonRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.PersonnelActual
{
    public class PersonnelActualCorrespondsToPersonnelClassRelationshipCollection : RelationshipCollection<PersonnelActualCorrespondsToPersonnelClassRelationship, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass>
    {
        public PersonnelActualCorrespondsToPersonnelClassRelationshipCollection(IEnumerable<PersonnelActualCorrespondsToPersonnelClassRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelActualCorrespondsToPersonnelClassRelationship>())
        {
        }
    }
}
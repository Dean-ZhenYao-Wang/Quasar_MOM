namespace MOM.Domain.Common.Relationship.isa95.PersonnelSpecification
{
    public class PersonnelSpecificationCorrespondsToPersonnelClassRelationshipCollection : RelationshipCollection<PersonnelSpecificationCorrespondsToPersonnelClassRelationship, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass>
    {
        public PersonnelSpecificationCorrespondsToPersonnelClassRelationshipCollection(IEnumerable<PersonnelSpecificationCorrespondsToPersonnelClassRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelSpecificationCorrespondsToPersonnelClassRelationship>())
        {
        }
    }
}
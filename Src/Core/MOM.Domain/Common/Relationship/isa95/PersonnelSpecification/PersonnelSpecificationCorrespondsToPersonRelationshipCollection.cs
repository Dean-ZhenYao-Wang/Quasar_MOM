namespace MOM.Domain.Common.Relationship.isa95.PersonnelSpecification
{
    public class PersonnelSpecificationCorrespondsToPersonRelationshipCollection : RelationshipCollection<PersonnelSpecificationCorrespondsToPersonRelationship, Domain.isa95.CommonObjectModels.Part2.Personnel.Person>
    {
        public PersonnelSpecificationCorrespondsToPersonRelationshipCollection(IEnumerable<PersonnelSpecificationCorrespondsToPersonRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelSpecificationCorrespondsToPersonRelationship>())
        {
        }
    }
}
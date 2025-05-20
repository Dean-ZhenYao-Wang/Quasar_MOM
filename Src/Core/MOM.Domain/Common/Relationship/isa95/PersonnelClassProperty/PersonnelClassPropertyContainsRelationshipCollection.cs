namespace MOM.Domain.Common.Relationship.isa95.PersonnelClassProperty
{
    public class PersonnelClassPropertyContainsRelationshipCollection : RelationshipCollection<PersonnelClassPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClassProperty>
    {
        public PersonnelClassPropertyContainsRelationshipCollection()
        { }

        public PersonnelClassPropertyContainsRelationshipCollection(IEnumerable<PersonnelClassPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelClassPropertyContainsRelationship>())
        {
        }
    }
}
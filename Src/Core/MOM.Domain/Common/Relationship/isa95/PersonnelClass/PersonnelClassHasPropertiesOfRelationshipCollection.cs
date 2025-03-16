namespace MOM.Domain.Common.Relationship.isa95.PersonnelClass
{
    public class PersonnelClassHasPropertiesOfRelationshipCollection : RelationshipCollection<PersonnelClassHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClassProperty>
    {
        public PersonnelClassHasPropertiesOfRelationshipCollection(IEnumerable<PersonnelClassHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelClassHasPropertiesOfRelationship>())
        {
        }
    }
}
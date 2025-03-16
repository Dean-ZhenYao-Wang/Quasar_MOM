namespace MOM.Domain.Common.Relationship.isa95.PersonnelClass
{
    public class PersonnelClassIncludesPropertiesOfRelationshipCollection : RelationshipCollection<PersonnelClassIncludesPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass>
    {
        public PersonnelClassIncludesPropertiesOfRelationshipCollection(IEnumerable<PersonnelClassIncludesPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelClassIncludesPropertiesOfRelationship>())
        {
        }
    }
}
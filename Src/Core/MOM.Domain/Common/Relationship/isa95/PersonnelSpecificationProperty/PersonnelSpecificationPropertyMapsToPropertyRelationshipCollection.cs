namespace MOM.Domain.Common.Relationship.isa95.PersonnelSpecificationProperty
{
    public class PersonnelSpecificationPropertyMapsToPropertyRelationshipCollection : RelationshipCollection<PersonnelSpecificationPropertyMapsToPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonProperty>
    {
        public PersonnelSpecificationPropertyMapsToPropertyRelationshipCollection(IEnumerable<PersonnelSpecificationPropertyMapsToPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelSpecificationPropertyMapsToPropertyRelationship>())
        {
        }
    }
}
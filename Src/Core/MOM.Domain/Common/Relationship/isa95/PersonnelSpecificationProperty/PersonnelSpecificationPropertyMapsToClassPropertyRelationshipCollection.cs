namespace MOM.Domain.Common.Relationship.isa95.PersonnelSpecificationProperty
{
    public class PersonnelSpecificationPropertyMapsToClassPropertyRelationshipCollection : RelationshipCollection<PersonnelSpecificationPropertyMapsToClassPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClassProperty>
    {
        public PersonnelSpecificationPropertyMapsToClassPropertyRelationshipCollection(IEnumerable<PersonnelSpecificationPropertyMapsToClassPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelSpecificationPropertyMapsToClassPropertyRelationship>())
        {
        }
    }
}
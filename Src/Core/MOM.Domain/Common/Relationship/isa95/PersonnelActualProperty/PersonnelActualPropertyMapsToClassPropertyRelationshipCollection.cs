namespace MOM.Domain.Common.Relationship.isa95.PersonnelActualProperty
{
    public class PersonnelActualPropertyMapsToClassPropertyRelationshipCollection : RelationshipCollection<PersonnelActualPropertyMapsToClassPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClassProperty>
    {
        public PersonnelActualPropertyMapsToClassPropertyRelationshipCollection(IEnumerable<PersonnelActualPropertyMapsToClassPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelActualPropertyMapsToClassPropertyRelationship>())
        {
        }
    }
}
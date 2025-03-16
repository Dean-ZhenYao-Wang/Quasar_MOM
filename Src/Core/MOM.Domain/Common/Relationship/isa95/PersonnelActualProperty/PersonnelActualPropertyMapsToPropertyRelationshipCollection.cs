namespace MOM.Domain.Common.Relationship.isa95.PersonnelActualProperty
{
    public class PersonnelActualPropertyMapsToPropertyRelationshipCollection : RelationshipCollection<PersonnelActualPropertyMapsToPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonProperty>
    {
        public PersonnelActualPropertyMapsToPropertyRelationshipCollection(IEnumerable<PersonnelActualPropertyMapsToPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelActualPropertyMapsToPropertyRelationship>())
        {
        }
    }
}
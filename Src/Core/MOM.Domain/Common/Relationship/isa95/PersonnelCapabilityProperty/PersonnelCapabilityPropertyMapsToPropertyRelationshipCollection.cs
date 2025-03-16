namespace MOM.Domain.Common.Relationship.isa95.PersonnelCapabilityProperty
{
    public class PersonnelCapabilityPropertyMapsToPropertyRelationshipCollection : RelationshipCollection<PersonnelCapabilityPropertyMapsToPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonProperty>
    {
        public PersonnelCapabilityPropertyMapsToPropertyRelationshipCollection(IEnumerable<PersonnelCapabilityPropertyMapsToPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelCapabilityPropertyMapsToPropertyRelationship>())
        {
        }
    }
}
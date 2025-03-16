namespace MOM.Domain.Common.Relationship.isa95.PersonnelCapabilityProperty
{
    public class PersonnelCapabilityPropertyMapsToClassPropertyRelationshipCollection : RelationshipCollection<PersonnelCapabilityPropertyMapsToClassPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClassProperty>
    {
        public PersonnelCapabilityPropertyMapsToClassPropertyRelationshipCollection(IEnumerable<PersonnelCapabilityPropertyMapsToClassPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelCapabilityPropertyMapsToClassPropertyRelationship>())
        {
        }
    }
}
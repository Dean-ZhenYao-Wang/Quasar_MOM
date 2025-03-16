namespace MOM.Domain.Common.Relationship.isa95.PersonnelRequirementProperty
{
    public class PersonnelRequirementPropertyMapsToClassPropertyRelationshipCollection : RelationshipCollection<PersonnelRequirementPropertyMapsToClassPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClassProperty>
    {
        public PersonnelRequirementPropertyMapsToClassPropertyRelationshipCollection(IEnumerable<PersonnelRequirementPropertyMapsToClassPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelRequirementPropertyMapsToClassPropertyRelationship>())
        {
        }
    }
}
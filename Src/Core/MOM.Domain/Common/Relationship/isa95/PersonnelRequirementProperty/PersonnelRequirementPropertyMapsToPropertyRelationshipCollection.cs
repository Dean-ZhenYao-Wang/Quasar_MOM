namespace MOM.Domain.Common.Relationship.isa95.PersonnelRequirementProperty
{
    public class PersonnelRequirementPropertyMapsToPropertyRelationshipCollection : RelationshipCollection<PersonnelRequirementPropertyMapsToPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonProperty>
    {
        public PersonnelRequirementPropertyMapsToPropertyRelationshipCollection(IEnumerable<PersonnelRequirementPropertyMapsToPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelRequirementPropertyMapsToPropertyRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.PersonnelRequirementProperty
{
    public class PersonnelRequirementPropertyContainsRelationshipCollection : RelationshipCollection<PersonnelRequirementPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PersonnelRequirementProperty>
    {
        public PersonnelRequirementPropertyContainsRelationshipCollection(IEnumerable<PersonnelRequirementPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelRequirementPropertyContainsRelationship>())
        {
        }
    }
}
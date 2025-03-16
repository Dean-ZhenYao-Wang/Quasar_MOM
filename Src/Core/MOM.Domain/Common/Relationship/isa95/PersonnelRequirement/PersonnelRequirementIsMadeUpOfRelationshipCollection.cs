namespace MOM.Domain.Common.Relationship.isa95.PersonnelRequirement
{
    public class PersonnelRequirementIsMadeUpOfRelationshipCollection : RelationshipCollection<PersonnelRequirementIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PersonnelRequirement>
    {
        public PersonnelRequirementIsMadeUpOfRelationshipCollection(IEnumerable<PersonnelRequirementIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelRequirementIsMadeUpOfRelationship>())
        {
        }
    }
}
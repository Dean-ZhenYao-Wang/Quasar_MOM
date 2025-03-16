namespace MOM.Domain.Common.Relationship.isa95.PersonnelRequirement
{
    public class PersonnelRequirementHasValuesOfRelationshipCollection : RelationshipCollection<PersonnelRequirementHasValuesOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsSchedule.PersonnelRequirementProperty>
    {
        public PersonnelRequirementHasValuesOfRelationshipCollection(IEnumerable<PersonnelRequirementHasValuesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelRequirementHasValuesOfRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.PersonnelRequirement
{
    public class PersonnelRequirementOperationalLocationRelRelationshipCollection : RelationshipCollection<PersonnelRequirementOperationalLocationRelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>
    {
        public PersonnelRequirementOperationalLocationRelRelationshipCollection(IEnumerable<PersonnelRequirementOperationalLocationRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelRequirementOperationalLocationRelRelationship>())
        {
        }
    }
}
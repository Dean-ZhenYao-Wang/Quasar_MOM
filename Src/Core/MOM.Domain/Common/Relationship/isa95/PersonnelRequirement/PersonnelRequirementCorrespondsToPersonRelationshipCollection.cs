namespace MOM.Domain.Common.Relationship.isa95.PersonnelRequirement
{
    public class PersonnelRequirementCorrespondsToPersonRelationshipCollection : RelationshipCollection<PersonnelRequirementCorrespondsToPersonRelationship, Domain.isa95.CommonObjectModels.Part2.Personnel.Person>
    {
        public PersonnelRequirementCorrespondsToPersonRelationshipCollection(IEnumerable<PersonnelRequirementCorrespondsToPersonRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelRequirementCorrespondsToPersonRelationship>())
        {
        }
    }
}
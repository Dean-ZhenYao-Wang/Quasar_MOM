namespace MOM.Domain.Common.Relationship.isa95.PersonnelRequirement
{
    public class PersonnelRequirementCorrespondsToPersonnelClassRelationshipCollection : RelationshipCollection<PersonnelRequirementCorrespondsToPersonnelClassRelationship, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass>
    {
        public PersonnelRequirementCorrespondsToPersonnelClassRelationshipCollection(IEnumerable<PersonnelRequirementCorrespondsToPersonnelClassRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelRequirementCorrespondsToPersonnelClassRelationship>())
        {
        }
    }
}
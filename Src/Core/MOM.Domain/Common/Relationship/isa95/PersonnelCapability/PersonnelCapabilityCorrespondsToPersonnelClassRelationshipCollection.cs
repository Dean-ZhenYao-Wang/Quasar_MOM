namespace MOM.Domain.Common.Relationship.isa95.PersonnelCapability
{
    public class PersonnelCapabilityCorrespondsToPersonnelClassRelationshipCollection : RelationshipCollection<PersonnelCapabilityCorrespondsToPersonnelClassRelationship, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass>
    {
        public PersonnelCapabilityCorrespondsToPersonnelClassRelationshipCollection(IEnumerable<PersonnelCapabilityCorrespondsToPersonnelClassRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelCapabilityCorrespondsToPersonnelClassRelationship>())
        {
        }
    }
}
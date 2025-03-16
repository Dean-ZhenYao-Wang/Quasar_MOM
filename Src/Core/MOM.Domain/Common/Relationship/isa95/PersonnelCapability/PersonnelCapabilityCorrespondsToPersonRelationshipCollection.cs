namespace MOM.Domain.Common.Relationship.isa95.PersonnelCapability
{
    public class PersonnelCapabilityCorrespondsToPersonRelationshipCollection : RelationshipCollection<PersonnelCapabilityCorrespondsToPersonRelationship, Domain.isa95.CommonObjectModels.Part2.Personnel.Person>
    {
        public PersonnelCapabilityCorrespondsToPersonRelationshipCollection(IEnumerable<PersonnelCapabilityCorrespondsToPersonRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelCapabilityCorrespondsToPersonRelationship>())
        {
        }
    }
}
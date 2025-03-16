namespace MOM.Domain.Common.Relationship.isa95.PersonnelCapability
{
    public class PersonnelCapabilityOperationalLocationRelRelationshipCollection : RelationshipCollection<PersonnelCapabilityOperationalLocationRelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>
    {
        public PersonnelCapabilityOperationalLocationRelRelationshipCollection(IEnumerable<PersonnelCapabilityOperationalLocationRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelCapabilityOperationalLocationRelRelationship>())
        {
        }
    }
}
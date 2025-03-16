namespace MOM.Domain.Common.Relationship.isa95.PersonnelCapability
{
    public class PersonnelCapabilityIsMadeUpOfRelationshipCollection : RelationshipCollection<PersonnelCapabilityIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PersonnelCapability>
    {
        public PersonnelCapabilityIsMadeUpOfRelationshipCollection(IEnumerable<PersonnelCapabilityIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelCapabilityIsMadeUpOfRelationship>())
        {
        }
    }
}
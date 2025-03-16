namespace MOM.Domain.Common.Relationship.isa95.PersonnelCapabilityProperty
{
    public class PersonnelCapabilityPropertyContainsRelationshipCollection : RelationshipCollection<PersonnelCapabilityPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PersonnelCapabilityProperty>
    {
        public PersonnelCapabilityPropertyContainsRelationshipCollection(IEnumerable<PersonnelCapabilityPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelCapabilityPropertyContainsRelationship>())
        {
        }
    }
}
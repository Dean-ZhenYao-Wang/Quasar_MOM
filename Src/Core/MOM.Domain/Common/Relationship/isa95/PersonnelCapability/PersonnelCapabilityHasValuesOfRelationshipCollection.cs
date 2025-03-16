namespace MOM.Domain.Common.Relationship.isa95.PersonnelCapability
{
    public class PersonnelCapabilityHasValuesOfRelationshipCollection : RelationshipCollection<PersonnelCapabilityHasValuesOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsCapability.PersonnelCapabilityProperty>
    {
        public PersonnelCapabilityHasValuesOfRelationshipCollection(IEnumerable<PersonnelCapabilityHasValuesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelCapabilityHasValuesOfRelationship>())
        {
        }
    }
}
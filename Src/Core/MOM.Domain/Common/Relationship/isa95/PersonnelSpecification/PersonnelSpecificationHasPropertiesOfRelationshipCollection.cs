namespace MOM.Domain.Common.Relationship.isa95.PersonnelSpecification
{
    public class PersonnelSpecificationHasPropertiesOfRelationshipCollection : RelationshipCollection<PersonnelSpecificationHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PersonnelSpecificationProperty>
    {
        public PersonnelSpecificationHasPropertiesOfRelationshipCollection(IEnumerable<PersonnelSpecificationHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelSpecificationHasPropertiesOfRelationship>())
        {
        }
    }
}
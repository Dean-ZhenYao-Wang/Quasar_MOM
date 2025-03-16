namespace MOM.Domain.Common.Relationship.isa95.PersonnelSpecification
{
    public class PersonnelSpecificationIsMadeUpOfRelationshipCollection : RelationshipCollection<PersonnelSpecificationIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PersonnelSpecification>
    {
        public PersonnelSpecificationIsMadeUpOfRelationshipCollection(IEnumerable<PersonnelSpecificationIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelSpecificationIsMadeUpOfRelationship>())
        {
        }
    }
}
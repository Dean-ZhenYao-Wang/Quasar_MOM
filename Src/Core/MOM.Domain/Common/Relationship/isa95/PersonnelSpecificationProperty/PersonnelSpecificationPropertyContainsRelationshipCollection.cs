namespace MOM.Domain.Common.Relationship.isa95.PersonnelSpecificationProperty
{
    public class PersonnelSpecificationPropertyContainsRelationshipCollection : RelationshipCollection<PersonnelSpecificationPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsDefinition.PersonnelSpecificationProperty>
    {
        public PersonnelSpecificationPropertyContainsRelationshipCollection(IEnumerable<PersonnelSpecificationPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelSpecificationPropertyContainsRelationship>())
        {
        }
    }
}
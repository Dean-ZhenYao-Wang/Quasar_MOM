namespace MOM.Domain.Common.Relationship.isa95.PersonnelSpecification
{
    public class PersonnelSpecificationOperationalLocationRelRelationshipCollection : RelationshipCollection<PersonnelSpecificationOperationalLocationRelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>
    {
        public PersonnelSpecificationOperationalLocationRelRelationshipCollection(IEnumerable<PersonnelSpecificationOperationalLocationRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelSpecificationOperationalLocationRelRelationship>())
        {
        }
    }
}
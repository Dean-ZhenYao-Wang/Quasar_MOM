namespace MOM.Domain.Common.Relationship.isa95.PersonnelSegmentSpecification
{
    public class PersonnelSegmentSpecificationOperationalLocationRelRelationshipCollection : RelationshipCollection<PersonnelSegmentSpecificationOperationalLocationRelRelationship, Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation>
    {
        public PersonnelSegmentSpecificationOperationalLocationRelRelationshipCollection(IEnumerable<PersonnelSegmentSpecificationOperationalLocationRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelSegmentSpecificationOperationalLocationRelRelationship>())
        {
        }
    }
}
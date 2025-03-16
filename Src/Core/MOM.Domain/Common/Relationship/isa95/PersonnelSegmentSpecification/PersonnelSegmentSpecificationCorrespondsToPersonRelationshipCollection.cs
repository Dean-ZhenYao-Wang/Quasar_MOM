namespace MOM.Domain.Common.Relationship.isa95.PersonnelSegmentSpecification
{
    public class PersonnelSegmentSpecificationCorrespondsToPersonRelationshipCollection : RelationshipCollection<PersonnelSegmentSpecificationCorrespondsToPersonRelationship, Domain.isa95.CommonObjectModels.Part2.Personnel.Person>
    {
        public PersonnelSegmentSpecificationCorrespondsToPersonRelationshipCollection(IEnumerable<PersonnelSegmentSpecificationCorrespondsToPersonRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelSegmentSpecificationCorrespondsToPersonRelationship>())
        {
        }
    }
}
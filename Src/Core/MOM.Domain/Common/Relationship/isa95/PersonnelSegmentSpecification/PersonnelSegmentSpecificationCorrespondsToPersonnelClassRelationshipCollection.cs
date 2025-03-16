namespace MOM.Domain.Common.Relationship.isa95.PersonnelSegmentSpecification
{
    public class PersonnelSegmentSpecificationCorrespondsToPersonnelClassRelationshipCollection : RelationshipCollection<PersonnelSegmentSpecificationCorrespondsToPersonnelClassRelationship, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass>
    {
        public PersonnelSegmentSpecificationCorrespondsToPersonnelClassRelationshipCollection(IEnumerable<PersonnelSegmentSpecificationCorrespondsToPersonnelClassRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelSegmentSpecificationCorrespondsToPersonnelClassRelationship>())
        {
        }
    }
}
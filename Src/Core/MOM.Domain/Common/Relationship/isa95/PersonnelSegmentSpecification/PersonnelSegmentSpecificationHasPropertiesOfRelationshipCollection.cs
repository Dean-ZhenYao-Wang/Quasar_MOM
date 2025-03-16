namespace MOM.Domain.Common.Relationship.isa95.PersonnelSegmentSpecification
{
    public class PersonnelSegmentSpecificationHasPropertiesOfRelationshipCollection : RelationshipCollection<PersonnelSegmentSpecificationHasPropertiesOfRelationship, Domain.isa95.CommonObjectModels.Part2.ProcessSegment.PersonnelSegmentSpecificationProperty>
    {
        public PersonnelSegmentSpecificationHasPropertiesOfRelationshipCollection(IEnumerable<PersonnelSegmentSpecificationHasPropertiesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelSegmentSpecificationHasPropertiesOfRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.PersonnelSegmentSpecificationProperty
{
    public class PersonnelSegmentSpecificationPropertyMapsToPropertyRelationshipCollection : RelationshipCollection<PersonnelSegmentSpecificationPropertyMapsToPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonProperty>
    {
        public PersonnelSegmentSpecificationPropertyMapsToPropertyRelationshipCollection(IEnumerable<PersonnelSegmentSpecificationPropertyMapsToPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelSegmentSpecificationPropertyMapsToPropertyRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.PersonnelSegmentSpecificationProperty
{
    public class PersonnelSegmentSpecificationPropertyMapsToClassPropertyRelationshipCollection : RelationshipCollection<PersonnelSegmentSpecificationPropertyMapsToClassPropertyRelationship, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClassProperty>
    {
        public PersonnelSegmentSpecificationPropertyMapsToClassPropertyRelationshipCollection(IEnumerable<PersonnelSegmentSpecificationPropertyMapsToClassPropertyRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelSegmentSpecificationPropertyMapsToClassPropertyRelationship>())
        {
        }
    }
}
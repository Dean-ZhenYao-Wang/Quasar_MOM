namespace MOM.Domain.Common.Relationship.isa95.PersonProperty
{
    public class PersonPropertyMapsToRelationshipCollection : RelationshipCollection<PersonPropertyMapsToRelationship, Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClassProperty>
    {
        public PersonPropertyMapsToRelationshipCollection(IEnumerable<PersonPropertyMapsToRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonPropertyMapsToRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.PersonnelActualProperty
{
    public class PersonnelActualPropertyContainsRelationshipCollection : RelationshipCollection<PersonnelActualPropertyContainsRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PersonnelActualProperty>
    {
        public PersonnelActualPropertyContainsRelationshipCollection(IEnumerable<PersonnelActualPropertyContainsRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelActualPropertyContainsRelationship>())
        {
        }
    }
}
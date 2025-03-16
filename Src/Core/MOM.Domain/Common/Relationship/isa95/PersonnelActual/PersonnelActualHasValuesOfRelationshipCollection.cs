namespace MOM.Domain.Common.Relationship.isa95.PersonnelActual
{
    public class PersonnelActualHasValuesOfRelationshipCollection : RelationshipCollection<PersonnelActualHasValuesOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PersonnelActualProperty>
    {
        public PersonnelActualHasValuesOfRelationshipCollection(IEnumerable<PersonnelActualHasValuesOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelActualHasValuesOfRelationship>())
        {
        }
    }
}
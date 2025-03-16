namespace MOM.Domain.Common.Relationship.isa95.PersonnelActual
{
    public class PersonnelActualIsMadeUpOfRelationshipCollection : RelationshipCollection<PersonnelActualIsMadeUpOfRelationship, Domain.isa95.CommonObjectModels.Part2.OperationsPerformance.PersonnelActual>
    {
        public PersonnelActualIsMadeUpOfRelationshipCollection(IEnumerable<PersonnelActualIsMadeUpOfRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelActualIsMadeUpOfRelationship>())
        {
        }
    }
}
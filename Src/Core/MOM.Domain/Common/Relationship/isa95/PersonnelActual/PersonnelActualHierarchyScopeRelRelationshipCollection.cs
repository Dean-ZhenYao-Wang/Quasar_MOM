namespace MOM.Domain.Common.Relationship.isa95.PersonnelActual
{
    public class PersonnelActualHierarchyScopeRelRelationshipCollection : RelationshipCollection<PersonnelActualHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public PersonnelActualHierarchyScopeRelRelationshipCollection(IEnumerable<PersonnelActualHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelActualHierarchyScopeRelRelationship>())
        {
        }
    }
}
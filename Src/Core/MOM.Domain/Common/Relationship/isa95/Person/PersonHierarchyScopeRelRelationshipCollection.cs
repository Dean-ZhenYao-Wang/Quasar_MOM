namespace MOM.Domain.Common.Relationship.isa95.Person
{
    public class PersonHierarchyScopeRelRelationshipCollection : RelationshipCollection<PersonHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public PersonHierarchyScopeRelRelationshipCollection(IEnumerable<PersonHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonHierarchyScopeRelRelationship>())
        {
        }
    }
}
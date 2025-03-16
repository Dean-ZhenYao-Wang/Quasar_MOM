namespace MOM.Domain.Common.Relationship.isa95.PersonnelClass
{
    public class PersonnelClassHierarchyScopeRelRelationshipCollection : RelationshipCollection<PersonnelClassHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public PersonnelClassHierarchyScopeRelRelationshipCollection(IEnumerable<PersonnelClassHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelClassHierarchyScopeRelRelationship>())
        {
        }
    }
}
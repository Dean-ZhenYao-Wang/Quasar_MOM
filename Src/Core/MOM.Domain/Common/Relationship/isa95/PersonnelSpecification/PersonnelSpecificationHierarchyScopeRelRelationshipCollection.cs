namespace MOM.Domain.Common.Relationship.isa95.PersonnelSpecification
{
    public class PersonnelSpecificationHierarchyScopeRelRelationshipCollection : RelationshipCollection<PersonnelSpecificationHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public PersonnelSpecificationHierarchyScopeRelRelationshipCollection(IEnumerable<PersonnelSpecificationHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelSpecificationHierarchyScopeRelRelationship>())
        {
        }
    }
}
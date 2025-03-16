namespace MOM.Domain.Common.Relationship.isa95.PersonnelCapability
{
    public class PersonnelCapabilityHierarchyScopeRelRelationshipCollection : RelationshipCollection<PersonnelCapabilityHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public PersonnelCapabilityHierarchyScopeRelRelationshipCollection(IEnumerable<PersonnelCapabilityHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelCapabilityHierarchyScopeRelRelationship>())
        {
        }
    }
}
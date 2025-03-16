namespace MOM.Domain.Common.Relationship.isa95.PersonnelRequirement
{
    public class PersonnelRequirementHierarchyScopeRelRelationshipCollection : RelationshipCollection<PersonnelRequirementHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public PersonnelRequirementHierarchyScopeRelRelationshipCollection(IEnumerable<PersonnelRequirementHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelRequirementHierarchyScopeRelRelationship>())
        {
        }
    }
}
namespace MOM.Domain.Common.Relationship.isa95.PersonnelSegmentSpecification
{
    public class PersonnelSegmentSpecificationHierarchyScopeRelRelationshipCollection : RelationshipCollection<PersonnelSegmentSpecificationHierarchyScopeRelRelationship, Domain.isa95.CommonObjectModels.HierarchyScope>
    {
        public PersonnelSegmentSpecificationHierarchyScopeRelRelationshipCollection(IEnumerable<PersonnelSegmentSpecificationHierarchyScopeRelRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<PersonnelSegmentSpecificationHierarchyScopeRelRelationship>())
        {
        }
    }
}
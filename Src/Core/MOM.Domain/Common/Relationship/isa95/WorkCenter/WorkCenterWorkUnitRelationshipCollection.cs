namespace MOM.Domain.Common.Relationship.isa95.WorkCenter
{
    public class WorkCenterWorkUnitRelationshipCollection : RelationshipCollection<WorkCenterWorkUnitRelationship, Domain.isa95.EquipmentHierarchy.WorkUnit>
    {
        public WorkCenterWorkUnitRelationshipCollection(IEnumerable<WorkCenterWorkUnitRelationship>? relationships = default) : base(relationships ?? Enumerable.Empty<WorkCenterWorkUnitRelationship>())
        {
        }
    }
}
using MOM.Domain.Common.Relationship.isa95.OperationsCapability;

namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsCapability
{
    public partial class OperationsCapability
    {
        public OperationsCapability(string ID, string locationDtId, HierarchyScope hierarchyScope, DateTime startTime, DateTime endTime) : this()
        {
            this.Id = Id;
            this.HierarchyScope = locationDtId;
            if (hierarchyScope != null && !this.HierarchyScopeRel.Targets.Where(m => m.DtId.Equals(hierarchyScope.DtId)).Any())
            {
                this.HierarchyScopeRel.Add(new OperationsCapabilityHierarchyScopeRelRelationship(this, hierarchyScope));
            }
            this.StartTime = startTime;
            this.EndTime = endTime;
        }
    }
}
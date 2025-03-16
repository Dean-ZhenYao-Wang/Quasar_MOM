using MOM.Domain.Common.EnumType;
using MOM.Domain.Common.Relationship.isa95.OperationsPerformance;

namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsPerformance
{
    public partial class OperationsPerformance
    {
        public OperationsPerformance(string ID, DateTime startTime, DateTime endTime, string hierarchyScopeDtId, HierarchyScope hierarchyScope, OperationsPerformanceOperationsType operationsType) : this()
        {
            this.Id = Id;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.HierarchyScope = hierarchyScopeDtId;
            if (hierarchyScope != null && !this.HierarchyScopeRel.Targets.Any(m => m.DtId.Equals(hierarchyScope.DtId)))
            {
                this.HierarchyScopeRel.Add(new OperationsPerformanceHierarchyScopeRelRelationship(this, hierarchyScope));
            }
            this.OperationsType = operationsType;
        }
    }
}
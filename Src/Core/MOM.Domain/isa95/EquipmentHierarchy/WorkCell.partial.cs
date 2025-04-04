using MOM.Domain.Common.EnumType;

namespace MOM.Domain.isa95.EquipmentHierarchy
{
    public partial class WorkCell
    {
        public WorkCell(string ID, string? description = null, bool active = false, Guid? responsibleDtId = null)
           : base(HierarchyScopeEquipmentLevel.Work_Cell, ID, description, active, responsibleDtId)
        {
        }
    }
}
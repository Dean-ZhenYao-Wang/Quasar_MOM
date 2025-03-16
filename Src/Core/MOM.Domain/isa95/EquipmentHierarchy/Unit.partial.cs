using MOM.Domain.Common.EnumType;

namespace MOM.Domain.isa95.EquipmentHierarchy
{
    public partial class Unit
    {
        public Unit(string ID, string? description = null, bool active = false, string? responsibleDtId = null)
           : base(HierarchyScopeEquipmentLevel.Unit, ID, description, active, responsibleDtId)
        {
        }
    }
}
using MOM.Domain.Common.EnumType;

namespace MOM.Domain.isa95.EquipmentHierarchy
{
    public partial class StorageUnit
    {
        public StorageUnit(string ID, string? description = null, bool active = false, string? responsibleDtId = null)
           : base(HierarchyScopeEquipmentLevel.Storage_Unit, ID, description, active, responsibleDtId)
        {
        }
    }
}
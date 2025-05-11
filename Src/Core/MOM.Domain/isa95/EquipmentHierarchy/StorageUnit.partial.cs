using MOM.Domain.Common.EnumType;

namespace MOM.Domain.isa95.EquipmentHierarchy
{
    public partial class StorageUnit
    {
        public StorageUnit(string ID, string address = "", string? description = null, bool active = false, Guid? responsibleDtId = null)
           : base(HierarchyScopeEquipmentLevel.Storage_Unit, ID, address,description, active, responsibleDtId)
        {
        }
    }
}
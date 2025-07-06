using MOM.Domain.Common.EnumType;

namespace MOM.Domain.isa95.EquipmentHierarchy
{
    public partial class StorageUnit
    {
        public StorageUnit(string id,string name, string address = "", string? description = null, bool active = false, Guid? responsibleDtId = null)
           : base(HierarchyScopeEquipmentLevel.Storage_Unit, id,name, address,description, active, responsibleDtId)
        {
        }
    }
}
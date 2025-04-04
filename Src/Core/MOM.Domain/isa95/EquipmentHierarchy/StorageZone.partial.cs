namespace MOM.Domain.isa95.EquipmentHierarchy
{
    public partial class StorageZone
    {
        public StorageZone(string name, string description = "", bool active = false, Guid? responsibleDtId = null)
            : base(Common.EnumType.HierarchyScopeEquipmentLevel.Storage_Zone, name, description, active, responsibleDtId)
        {
        }
    }
}
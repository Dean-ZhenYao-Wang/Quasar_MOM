namespace MOM.Domain.isa95.EquipmentHierarchy
{
    public partial class ProcessCell
    {
        public ProcessCell(string id, string name, string address = "", string description = "", bool active = false, Guid? responsibleDtId = null)
            : base(Common.EnumType.HierarchyScopeEquipmentLevel.Process_Cell, id, name, address, description, active, responsibleDtId)
        {
        }
    }
}
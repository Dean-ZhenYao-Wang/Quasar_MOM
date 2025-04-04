namespace MOM.Domain.isa95.EquipmentHierarchy
{
    public partial class ProcessCell
    {
        public ProcessCell(string name, string description = "", bool active = false, Guid? responsibleDtId = null)
            : base(Common.EnumType.HierarchyScopeEquipmentLevel.Process_Cell, name, description, active, responsibleDtId)
        {
        }
    }
}
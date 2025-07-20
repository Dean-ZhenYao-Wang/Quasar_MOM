namespace MOM.Domain.isa95.EquipmentHierarchy
{
    public partial class ProcessCell
    {
        public ProcessCell(string id, string name, string? description = null, bool active = false, string? address = null, Guid? responsibleDtId = null, Guid? sourceDtId = null) : base( id, name, Common.EnumType.HierarchyScopeEquipmentLevel.Process_Cell, description, active, address, responsibleDtId, sourceDtId)
        {
        }
    }
}
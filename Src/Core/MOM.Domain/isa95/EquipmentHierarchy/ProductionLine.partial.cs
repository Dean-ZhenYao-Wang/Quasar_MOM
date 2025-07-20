namespace MOM.Domain.isa95.EquipmentHierarchy
{
    public partial class ProductionLine
    {
        public ProductionLine(string id, string name, string? description = null, bool active = false, string? address = null, Guid? responsibleDtId = null, Guid? sourceDtId = null) : base(id, name, Common.EnumType.HierarchyScopeEquipmentLevel.Production_Line, description, active, address, responsibleDtId, sourceDtId)
        {
        }
    }
}
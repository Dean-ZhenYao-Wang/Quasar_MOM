namespace MOM.Domain.isa95.EquipmentHierarchy
{
    public partial class ProductionLine
    {
        public ProductionLine(string name, string description = "", bool active = false, string? responsibleDtId = null)
            : base(Common.EnumType.HierarchyScopeEquipmentLevel.Production_Line, name, description, active, responsibleDtId)
        {
        }
    }
}
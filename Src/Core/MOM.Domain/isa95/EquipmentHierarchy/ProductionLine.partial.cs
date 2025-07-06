namespace MOM.Domain.isa95.EquipmentHierarchy
{
    public partial class ProductionLine
    {
        public ProductionLine(string id, string name, string address = "", string description = "", bool active = false, Guid? responsibleDtId = null)
            : base(Common.EnumType.HierarchyScopeEquipmentLevel.Production_Line, id, name, address, description, active, responsibleDtId)
        {
        }
    }
}
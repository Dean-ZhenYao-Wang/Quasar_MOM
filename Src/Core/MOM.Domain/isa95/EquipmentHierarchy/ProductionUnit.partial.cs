namespace MOM.Domain.isa95.EquipmentHierarchy
{
    public partial class ProductionUnit
    {
        public ProductionUnit(string id, string name, string address = "", string description = "", bool active = false, Guid? responsibleDtId = null)
            : base(Common.EnumType.HierarchyScopeEquipmentLevel.Production_Unit, id, name, address, description, active, responsibleDtId)
        {
        }
    }
}
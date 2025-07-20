namespace MOM.Domain.isa95.EquipmentHierarchy
{
    public partial class ProductionUnit
    {
        public ProductionUnit(string id, string name, string? description = null, bool active = false, string? address = null, Guid? responsibleDtId = null, Guid? sourceDtId = null) : base( id, name, Common.EnumType.HierarchyScopeEquipmentLevel.Production_Unit, description, active, address, responsibleDtId, sourceDtId)
        {
        }
    }
}
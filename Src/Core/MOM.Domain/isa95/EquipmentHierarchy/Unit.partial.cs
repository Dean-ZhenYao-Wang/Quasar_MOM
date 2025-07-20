using MOM.Domain.Common.EnumType;

namespace MOM.Domain.isa95.EquipmentHierarchy
{
    public partial class Unit
    {
        public Unit(string id, string name, string? description = null, bool active = false, string? address = null, Guid? responsibleDtId = null, Guid? sourceDtId = null) : base( id, name, Common.EnumType.HierarchyScopeEquipmentLevel.Unit, description, active, address, responsibleDtId, sourceDtId)
        {
        }
    }
}
using MOM.Domain.Common.EnumType;

namespace MOM.Domain.isa95.EquipmentHierarchy
{
    public abstract partial class SiteAsset
    {
        public SiteAsset(HierarchyScopeEquipmentLevel equipmentLevel, string ID, string? description = null, bool active = false) : base(equipmentLevel, ID, description, active)
        {
        }
    }
}
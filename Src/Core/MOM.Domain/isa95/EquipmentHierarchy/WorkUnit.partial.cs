using MOM.Domain.Common.EnumType;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MOM.Domain.isa95.EquipmentHierarchy
{
    public partial class WorkUnit
    {
        public WorkUnit(HierarchyScopeEquipmentLevel equipmentLevel, string ID, string? description = null, bool active = false, string? responsibleDtId = null) : base(equipmentLevel, ID, description, active)
        {
            ResponsibleDtId = responsibleDtId;
        }

        public void Update(string name, string? description, bool active, string? responsibleDtId)
        {
            this.Id = name;
            this.Description = description;
            this.Active = active;
            this.ResponsibleDtId = responsibleDtId;
        }
    }
}
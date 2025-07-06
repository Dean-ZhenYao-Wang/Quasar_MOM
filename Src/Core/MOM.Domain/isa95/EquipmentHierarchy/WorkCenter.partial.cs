using MOM.Domain.Common.EnumType;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Text.Json.Serialization;

namespace MOM.Domain.isa95.EquipmentHierarchy
{
    public partial class WorkCenter
    {
        public WorkCenter(HierarchyScopeEquipmentLevel equipmentLevel, string id, string name, string address = "", string description = "", bool active = false, Guid? responsibleDtId = null) : base(equipmentLevel, id, name, address, description, active)
        {
            ResponsibleDtId = responsibleDtId;
        }

        public void Update(string name, string description, bool active, Guid? responsibleDtId = null)
        {
            this.Id = name;
            this.Description = description;
            this.Active = active;
            this.ResponsibleDtId = responsibleDtId;
        }
    }
}
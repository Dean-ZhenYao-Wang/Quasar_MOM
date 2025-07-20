using MOM.Domain.Common.EnumType;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Text.Json.Serialization;

namespace MOM.Domain.isa95.EquipmentHierarchy
{
    public partial class WorkCenter
    {
        public WorkCenter(string id, string name, Common.EnumType.HierarchyScopeEquipmentLevel equipmentLevel = HierarchyScopeEquipmentLevel.Work_Center,  string? description = null, bool active = false, string? address = null, Guid? responsibleDtId = null, Guid? sourceDtId = null) : base(equipmentLevel, id, name, description, active, address, responsibleDtId, sourceDtId)
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
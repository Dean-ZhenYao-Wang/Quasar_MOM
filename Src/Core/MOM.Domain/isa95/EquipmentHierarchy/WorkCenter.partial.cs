using MOM.Domain.Common.EnumType;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Text.Json.Serialization;

namespace MOM.Domain.isa95.EquipmentHierarchy
{
    public partial class WorkCenter
    {
        public WorkCenter(HierarchyScopeEquipmentLevel equipmentLevel, string ID, string address = "", string description = "", bool active = false, Guid? responsibleDtId = null) : base(equipmentLevel, ID, address, description, active)
        {
            ResponsibleDtId = responsibleDtId;
        }

        public override void ForcedDeletionContainTargets()
        {
            foreach (var wu in this.WorkUnit)
            {
                wu.Target.ForcedDeletion();
            }
        }

        public override void ForcedDeletion()
        {
            base.ForcedDeletion();
            this.WorkUnit.Clear();
        }

        public void Update(string name, string description, bool active, Guid? responsibleDtId = null)
        {
            this.Id = name;
            this.Description = description;
            this.Active = active;
            this.ResponsibleDtId = responsibleDtId;
        }

        public void AddWorkUnit(Guid workUnitDtId)
        {
            this.WorkUnit.Add(this.DtId, workUnitDtId);
            this.Contains.Add(this.DtId, workUnitDtId);
        }

        public void DeleteWorkUnit(Guid workUnitDtId)
        {
            this.WorkUnit.Remove(workUnitDtId);
            this.Contains.Remove(workUnitDtId);
        }
    }
}
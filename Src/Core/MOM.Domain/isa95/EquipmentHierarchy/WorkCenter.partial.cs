using MOM.Domain.Common.EnumType;
using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MOM.Domain.isa95.EquipmentHierarchy
{
    public partial class WorkCenter
    {
        public WorkCenter(HierarchyScopeEquipmentLevel equipmentLevel, string ID, string description = "", bool active = false, string? responsibleDtId = null) : base(equipmentLevel, ID, description, active)
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

        public void Update(string name, string description, bool active, string? responsibleDtId)
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
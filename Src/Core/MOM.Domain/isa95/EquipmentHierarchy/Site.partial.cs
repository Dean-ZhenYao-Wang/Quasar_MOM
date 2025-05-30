﻿namespace MOM.Domain.isa95.EquipmentHierarchy
{
    public partial class Site
    {
        public string? Address { get; set; }

        public Site(string name, string description = "", bool active = false, string address = "", Guid? responsibleDtId = null)
            : base(Common.EnumType.HierarchyScopeEquipmentLevel.Site, name, address, description, active)
        {
            this.Address = address;
            this.ResponsibleDtId = responsibleDtId;
        }

        public override void ForcedDeletionContainTargets()
        {
            foreach (var area in this.Area)
            {
                area.Target.ForcedDeletion();
            }
        }

        public override void ForcedDeletion()
        {
            base.ForcedDeletion();
            this.Area.Clear();
        }

        public void Update(string name, string description, bool active, string address, Guid? responsibleDtId = null)
        {
            this.Id = name;
            this.Description = description;
            this.Active = active;
            this.Address = address;
            this.ResponsibleDtId = responsibleDtId;
        }

        public void DeleteArea(Guid areaDtId)
        {
            this.Area.Remove(areaDtId);
            this.Contains.Remove(areaDtId);
        }
    }
}
namespace MOM.Domain.isa95.EquipmentHierarchy
{
    public partial class Enterprise
    {
        /// <summary>
        /// 地址
        /// </summary>
        public string? Address { get; set; }

        public Enterprise(string name, string? description = null, bool active = false, string? address = null, Guid? responsibleDtId = null)
            : base(Common.EnumType.HierarchyScopeEquipmentLevel.Enterprise, name, description, active)
        {
            this.Address = address;
            this.ResponsibleDtId = responsibleDtId;
        }

        public override void ForcedDeletionContainTargets()
        {
            foreach (var t in this.Site)
            {
                t.Target.ForcedDeletion();
            }
        }

        public override void ForcedDeletion()
        {
            base.ForcedDeletion();
            this.Site.Clear();
        }

        public void Update(string name, string description, bool active, string address, Guid? responsibleDtId = null)
        {
            this.Id = name;
            this.Description = description;
            this.Active = active;
            this.Address = address;
            this.ResponsibleDtId = responsibleDtId;
        }

        public void DeleteSite(Guid siteDtId)
        {
            this.Site.Remove(siteDtId);
            this.Contains.Remove(siteDtId);
        }
    }
}
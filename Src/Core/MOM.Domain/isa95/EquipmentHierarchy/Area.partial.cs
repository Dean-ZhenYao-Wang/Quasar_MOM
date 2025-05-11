namespace MOM.Domain.isa95.EquipmentHierarchy
{
    public partial class Area
    {
        public string? Address { get; set; }

        public Area(string name, string description = "", bool active = false, string address = "", Guid? responsibleDtId = null)
            : base(Common.EnumType.HierarchyScopeEquipmentLevel.Area, name, address, description, active)
        {
            this.Address = address;
            this.ResponsibleDtId = responsibleDtId;
        }

        public override void ForcedDeletionContainTargets()
        {
            foreach (var wc in this.WorkCenter)
            {
                wc.Target.ForcedDeletion();
            }
        }

        public override void ForcedDeletion()
        {
            base.ForcedDeletion();
            this.WorkCenter.Clear();
        }

        public void Update(string name, string description, bool active, string address, Guid? responsibleDtId = null)
        {
            this.Id = name;
            this.Description = description;
            this.Active = active;
            this.Address = address;
            this.ResponsibleDtId = responsibleDtId;
        }

        public void AddWorkCenter(Guid workCenterdtId)
        {
            this.Contains.Add(new Common.Relationship.isa95.HierarchyScope.HierarchyScopeContainsRelationship(this.DtId, workCenterdtId));
            this.WorkCenter.Add(new Common.Relationship.isa95.Area.AreaWorkCenterRelationship(this.DtId, workCenterdtId));
        }

        public void DeleteWorkCenter(Guid workCenterdtId)
        {
            this.Contains.Remove(workCenterdtId);
            this.WorkCenter.Remove(workCenterdtId);
        }
    }
}
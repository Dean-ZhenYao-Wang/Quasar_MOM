namespace MOM.Domain.isa95.EquipmentHierarchy
{
    public partial class Area
    {
        public string? Address { get; set; }

        public Area(string id, string name, string? description = null, bool active = false, string? address = null, Guid? responsibleDtId = null, Guid? sourceDtId = null)
            : base(Common.EnumType.HierarchyScopeEquipmentLevel.Area, id, name, description, active, address, responsibleDtId, sourceDtId)
        {
        }

        public void Update(string name, string description, bool active, string address, Guid? responsibleDtId = null)
        {
            this.Id = name;
            this.Description = description;
            this.Active = active;
            this.Address = address;
            this.ResponsibleDtId = responsibleDtId;
        }
    }
}
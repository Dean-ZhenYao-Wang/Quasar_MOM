namespace MOM.Domain.isa95.EquipmentHierarchy
{
    public partial class Enterprise
    {

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
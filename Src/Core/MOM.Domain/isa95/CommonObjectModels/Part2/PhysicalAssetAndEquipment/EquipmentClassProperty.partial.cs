namespace MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment
{
    public partial class EquipmentClassProperty
    {
        public string Description { get; set; }

        public EquipmentClassProperty(string ID, string description, string value, string valueUnitOfMeasure) : this()
        {
            this.Id = Id;
            Description = description;
            Value = value;
            ValueUnitOfMeasure = valueUnitOfMeasure;
        }

        public void ContainsAddTarget(EquipmentClassProperty equipmentClassProperty)
        {
            this.Contains.Add(new Common.Relationship.isa95.EquipmentClassProperty.EquipmentClassPropertyContainsRelationship(this, equipmentClassProperty));
        }

        public void Delete()
        {
            foreach(var item in this.Contains.Where(m=>m.Target.IsDelete==false))
            {
                item.Target.Delete();
            }
            this.IsDelete = true;
        }
    }
}
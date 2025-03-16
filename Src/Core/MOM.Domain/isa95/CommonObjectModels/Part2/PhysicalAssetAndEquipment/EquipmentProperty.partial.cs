using MOM.Domain.isa95.CommonObjectModels.Part2.Personnel;

namespace MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment
{
    public partial class EquipmentProperty
    {
        public EquipmentProperty(string ID, string description, string value, string valueUnitOfMeasure) : this()
        {
            this.Id = Id;
            this.Description = description;
            this.Value = value;
            this.ValueUnitOfMeasure = valueUnitOfMeasure;
        }

        public void ContainsAddTarget(EquipmentProperty equipmentProperty)
        {
            this.Contains.Add(new Common.Relationship.isa95.EquipmentProperty.EquipmentPropertyContainsRelationship(this, equipmentProperty));
        }

        public void Delete()
        {
            foreach (var item in this.Contains.Where(m => m.Target.IsDelete == false))
            {
                item.Target.Delete();
            }
            this.IsDelete = true;
        }

        public void Update(string iD, string? description, string? value, string? valueUnitOfMeasure)
        {
            this.Id = Id;
            this.Description = description ?? string.Empty;
            this.Value = value;
            this.ValueUnitOfMeasure = valueUnitOfMeasure;
        }
    }
}
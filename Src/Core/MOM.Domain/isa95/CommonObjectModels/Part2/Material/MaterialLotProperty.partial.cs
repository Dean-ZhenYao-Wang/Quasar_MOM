namespace MOM.Domain.isa95.CommonObjectModels.Part2.Material
{
    public partial class MaterialLotProperty
    {
        public MaterialLotProperty(string ID, string description, string value, string valueUnitOfMeasure) : this()
        {
            this.Id = Id;
            this.Description = description;
            this.Value = value;
            this.ValueUnitOfMeasure = valueUnitOfMeasure;
        }
    }
}
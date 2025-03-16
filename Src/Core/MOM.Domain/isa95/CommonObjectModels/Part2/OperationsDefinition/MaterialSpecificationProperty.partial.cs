namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsDefinition
{
    public partial class MaterialSpecificationProperty
    {
        public MaterialSpecificationProperty(string ID, string value, string valueUnitOfMeasure) : this()
        {
            this.Id = Id;
            this.Value = value;
            this.ValueUnitOfMeasure = valueUnitOfMeasure;
        }
    }
}
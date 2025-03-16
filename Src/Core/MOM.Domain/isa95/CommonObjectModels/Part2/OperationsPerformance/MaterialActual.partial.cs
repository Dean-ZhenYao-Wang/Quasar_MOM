using MOM.Domain.Common.Relationship.isa95.MaterialActual;
using MOM.Domain.isa95.CommonObjectModels.Part2.Material;

namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsPerformance
{
    public partial class MaterialActual
    {
        public string Description { get; set; }

        public MaterialActual(string description, MaterialLot materialLot, double quantity, string quantityUnitOfMeasure) : this()
        {
            this.Description = description;
            this.CorrespondsToLot.Add(new MaterialActualCorrespondsToLotRelationship
                (this, materialLot));
            this.Quantity = quantity;
            this.QuantityUnitOfMeasure = quantityUnitOfMeasure;
        }
    }
}
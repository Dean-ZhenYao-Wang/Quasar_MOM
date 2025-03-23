using MOM.Domain.Common.Relationship.isa95.MaterialSublot;

namespace MOM.Domain.isa95.CommonObjectModels.Part2.Material
{
    public partial class MaterialSublot
    {
        public string Description { get; set; }

        public MaterialSublot(string ID, string description, string storageLocation, double quantity, string quantityUnitOfMeasure) : this()
        {
            this.Id = Id;
            this.Description = description;
            this.StorageLocation = storageLocation;
            this.Quantity = quantity;
            this.QuantityUnitOfMeasure = quantityUnitOfMeasure;
        }

        public void IsAssembledFromLotAddTarget(MaterialLot target)
        {
            this.IsAssembledFromLot.Add(new MaterialSublotIsAssembledFromLotRelationship(this, target));
        }

        public void IsAssembledFromLotAddTarget(Guid materialLotDtId)
        {
            this.IsAssembledFromLot.Add(new MaterialSublotIsAssembledFromLotRelationship(this.DtId, materialLotDtId));
        }
    }
}
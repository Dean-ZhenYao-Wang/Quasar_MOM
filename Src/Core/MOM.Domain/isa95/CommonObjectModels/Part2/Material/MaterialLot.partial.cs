using MOM.Domain.Common.EnumType;
using MOM.Domain.Common.Relationship.isa95.MaterialLot;

namespace MOM.Domain.isa95.CommonObjectModels.Part2.Material
{
    public partial class MaterialLot
    {
        public string Description { get; set; }

        public MaterialLot(string ID, string description, string status, double? quantity = null, string? quantityUnitOfMeasure = null, MaterialLotDisposition? disposition = null, HierarchyScope? hierarchyScope = null, MOM.Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation? storageLocation = null,
            MaterialLotStorageLocationType? storageLocationType = null, MaterialLotAssemblyType? assemblyType = null, MaterialLotAssemblyRelationship? assemblyRelationship = null) : this()
        {
            this.Id = Id;
            this.Description = description;
            this.Status = status;
            this.Quantity = quantity;
            this.QuantityUnitOfMeasure = quantityUnitOfMeasure;
            this.Disposition = disposition;
            if (hierarchyScope != null)
                this.HierarchyScopeRelAddTarget(hierarchyScope);
            if (storageLocation != null)
                this.StorageLocationRelAddTarget(storageLocation, storageLocationType);
            this.AssemblyType = assemblyType;
            this.AssemblyRelationship = assemblyRelationship;
        }

        public void StorageLocationRelAddTarget(MOM.Domain.isa95.CommonObjectModels.Part2.OperationalLocation.OperationalLocation target, MaterialLotStorageLocationType? storageLocationType)
        {
            this.StorageLocation = target.Id;
            this.StorageLocationType = storageLocationType;
            this.StorageLocationRel.Add(new MaterialLotStorageLocationRelRelationship(this, target));
        }

        public void HierarchyScopeRelAddTarget(HierarchyScope target)
        {
            this.HierarchyScope = target.Id;
            this.HierarchyScopeRel.Add(new MaterialLotHierarchyScopeRelRelationship(this, target));
        }

        public void HasValuesOfAddTarget(MaterialLotProperty target)
        {
            this.HasValuesOf.Add(new MaterialLotHasValuesOfRelationship(this, target));
        }

        public void DefinedByAddTarget(MaterialDefinition target)
        {
            this.DefinedBy.Add(new MaterialLotDefinedByRelationship(this, target));
        }

        public void DefinedByAddTarget(string materialDefinitionDtId)
        {
            this.DefinedBy.Add(new MaterialLotDefinedByRelationship(this.DtId, materialDefinitionDtId));
        }

        public void IsAssembledFromSubLotAddTarget(MaterialSublot target)
        {
            this.IsAssembledFromSublot.Add(new MaterialLotIsAssembledFromSublotRelationship(this, target));
        }

        public void IsAssembledFromSubLotAddTarget(string targetDtId)
        {
            this.IsAssembledFromSublot.Add(new MaterialLotIsAssembledFromSublotRelationship(this.DtId, targetDtId));
        }
    }
}
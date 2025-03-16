using MOM.Domain.Common.Relationship.isa95.PhysicalAssetClass;

namespace MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment
{
    public partial class PhysicalAssetClass
    {
        public PhysicalAssetClass(string ID, string description = "", string manufacturer = "", string hierarchyScope = "") : this()
        {
            this.Id = Id;
            this.Description = description;
            this.Manufacturer = manufacturer;
            this.HierarchyScope = hierarchyScope;
            if (!string.IsNullOrWhiteSpace(hierarchyScope))
                this.HierarchyScopeRel.Add(new PhysicalAssetClassHierarchyScopeRelRelationship(this.DtId, hierarchyScope));
        }

        public string Description { get; private set; }
    }
}
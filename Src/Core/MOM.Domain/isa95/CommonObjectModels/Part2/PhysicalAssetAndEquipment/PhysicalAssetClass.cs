namespace MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.PhysicalAssetClass;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class PhysicalAssetClass : ResourceClass, IEquatable<PhysicalAssetClass>
    {
        public PhysicalAssetClass()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:PhysicalAssetClass;1";

        [JsonPropertyName("manufacturer")]
        public string? Manufacturer { get; set; }

        [JsonPropertyName("hierarchyScope")]
        public Guid? HierarchyScope { get; set; }

        [JsonIgnore]
        public virtual List<PhysicalAssetClassIncludesPropertiesOfRelationship> IncludesPropertiesOf { get; set; } = new List<PhysicalAssetClassIncludesPropertiesOfRelationship>();

        [JsonIgnore]
        public virtual List<PhysicalAssetClassIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<PhysicalAssetClassIsMadeUpOfRelationship>();

        /// <summary>
        /// ¿©’π Ù–‘
        /// </summary>
        public virtual PhysicalAssetClassProperty HasPropertiesOf { get; set; } = new PhysicalAssetClassProperty();

        [JsonIgnore]
        public virtual List<PhysicalAssetClassHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<PhysicalAssetClassHierarchyScopeRelRelationship>();

        public PhysicalAssetClass(string ID, string description = "", string manufacturer = "", Guid? hierarchyScope = null) : this()
        {
            this.Id = Id;
            this.Description = description;
            this.Manufacturer = manufacturer;
            this.HierarchyScope = hierarchyScope;
            if (hierarchyScope != null)
                this.HierarchyScopeRel.Add(new PhysicalAssetClassHierarchyScopeRelRelationship(this.DtId, hierarchyScope.Value));
        }

        public string Description { get; private set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetClass);
        }

        public bool Equals(PhysicalAssetClass? other)
        {
            return other is not null && base.Equals(other) && Manufacturer == other.Manufacturer && HierarchyScope == other.HierarchyScope;
        }

        public static bool operator ==(PhysicalAssetClass? left, PhysicalAssetClass? right)
        {
            return EqualityComparer<PhysicalAssetClass?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetClass? left, PhysicalAssetClass? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Manufacturer?.GetHashCode(), HierarchyScope?.GetHashCode());
        }

        public void Delete()
        {
            this.IsDelete = true;
        }
    }
}
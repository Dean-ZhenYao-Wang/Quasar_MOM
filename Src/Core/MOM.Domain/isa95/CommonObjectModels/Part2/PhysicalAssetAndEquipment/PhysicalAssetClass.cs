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
        public string? HierarchyScope { get; set; }

        [JsonIgnore]
        public virtual PhysicalAssetClassIncludesPropertiesOfRelationshipCollection IncludesPropertiesOf { get; set; } = new PhysicalAssetClassIncludesPropertiesOfRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetClassIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new PhysicalAssetClassIsMadeUpOfRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetClassHasPropertiesOfRelationshipCollection HasPropertiesOf { get; set; } = new PhysicalAssetClassHasPropertiesOfRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetClassHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new PhysicalAssetClassHierarchyScopeRelRelationshipCollection();

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
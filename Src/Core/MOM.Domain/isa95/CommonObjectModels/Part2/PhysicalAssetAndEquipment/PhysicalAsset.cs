namespace MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.PhysicalAsset;
    using MOM.Domain.isa95.CommonObjectModels;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PhysicalAsset : Resource, IEquatable<PhysicalAsset>
    {
        public PhysicalAsset()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:PhysicalAsset;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("fixedAssetID")]
        public string? FixedAssetID { get; set; }

        [JsonPropertyName("vendorID")]
        public string? VendorID { get; set; }

        [JsonPropertyName("physicalLocation")]
        public string? PhysicalLocation { get; set; }

        [JsonPropertyName("physicalLocationType")]
        public PhysicalAssetPhysicalLocationType? PhysicalLocationType { get; set; }

        [JsonIgnore]
        public virtual PhysicalAssetDefinedByRelationshipCollection DefinedBy { get; set; } = new PhysicalAssetDefinedByRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetHasValuesOfRelationshipCollection HasValuesOf { get; set; } = new PhysicalAssetHasValuesOfRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new PhysicalAssetIsMadeUpOfRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new PhysicalAssetHierarchyScopeRelRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetPhysicalLocationRelRelationshipCollection PhysicalLocationRel { get; set; } = new PhysicalAssetPhysicalLocationRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAsset);
        }

        public bool Equals(PhysicalAsset? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && FixedAssetID == other.FixedAssetID && VendorID == other.VendorID && PhysicalLocation == other.PhysicalLocation && PhysicalLocationType == other.PhysicalLocationType;
        }

        public static bool operator ==(PhysicalAsset? left, PhysicalAsset? right)
        {
            return EqualityComparer<PhysicalAsset?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAsset? left, PhysicalAsset? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), FixedAssetID?.GetHashCode(), VendorID?.GetHashCode(), PhysicalLocation?.GetHashCode(), PhysicalLocationType?.GetHashCode());
        }
    }
}
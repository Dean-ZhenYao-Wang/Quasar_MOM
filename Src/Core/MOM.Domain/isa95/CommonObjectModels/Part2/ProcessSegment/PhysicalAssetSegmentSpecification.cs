namespace MOM.Domain.isa95.CommonObjectModels.Part2.ProcessSegment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.PhysicalAssetSegmentSpecification;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PhysicalAssetSegmentSpecification : BaseEntity, IEquatable<PhysicalAssetSegmentSpecification>
    {
        public PhysicalAssetSegmentSpecification()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:PhysicalAssetSegmentSpecification;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("physicalLocation")]
        public string? PhysicalLocation { get; set; }

        [JsonPropertyName("physicalLocationType")]
        public PhysicalAssetSegmentSpecificationPhysicalLocationType? PhysicalLocationType { get; set; }

        [JsonPropertyName("physicalAssetUse")]
        public string? PhysicalAssetUse { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<PhysicalAssetSegmentSpecificationIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<PhysicalAssetSegmentSpecificationIsMadeUpOfRelationship>();

        [JsonIgnore]
public virtual List<PhysicalAssetSegmentSpecificationSpecifiesRelationship> Specifies { get; set; } = new List<PhysicalAssetSegmentSpecificationSpecifiesRelationship>();

        [JsonIgnore]
public virtual List<PhysicalAssetSegmentSpecificationHasPropertiesOfRelationship> HasPropertiesOf { get; set; } = new List<PhysicalAssetSegmentSpecificationHasPropertiesOfRelationship>();

        [JsonIgnore]
public virtual List<PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetClassRelationship> CorrespondsToPhysicalAssetClass { get; set; } = new List<PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetClassRelationship>();

        [JsonIgnore]
public virtual List<PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetRelationship> CorrespondsToPhysicalAsset { get; set; } = new List<PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetRelationship>();

        [JsonIgnore]
public virtual List<PhysicalAssetSegmentSpecificationHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<PhysicalAssetSegmentSpecificationHierarchyScopeRelRelationship>();

        [JsonIgnore]
public virtual List<PhysicalAssetSegmentSpecificationPhysicalLocationRelRelationship> PhysicalLocationRel { get; set; } = new List<PhysicalAssetSegmentSpecificationPhysicalLocationRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetSegmentSpecification);
        }

        public bool Equals(PhysicalAssetSegmentSpecification? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && PhysicalLocation == other.PhysicalLocation && PhysicalLocationType == other.PhysicalLocationType && PhysicalAssetUse == other.PhysicalAssetUse && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(PhysicalAssetSegmentSpecification? left, PhysicalAssetSegmentSpecification? right)
        {
            return EqualityComparer<PhysicalAssetSegmentSpecification?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetSegmentSpecification? left, PhysicalAssetSegmentSpecification? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), PhysicalLocation?.GetHashCode(), PhysicalLocationType?.GetHashCode(), PhysicalAssetUse?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}
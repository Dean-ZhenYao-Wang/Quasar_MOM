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
        public virtual PhysicalAssetSegmentSpecificationIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new PhysicalAssetSegmentSpecificationIsMadeUpOfRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetSegmentSpecificationSpecifiesRelationshipCollection Specifies { get; set; } = new PhysicalAssetSegmentSpecificationSpecifiesRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetSegmentSpecificationHasPropertiesOfRelationshipCollection HasPropertiesOf { get; set; } = new PhysicalAssetSegmentSpecificationHasPropertiesOfRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetClassRelationshipCollection CorrespondsToPhysicalAssetClass { get; set; } = new PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetClassRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetRelationshipCollection CorrespondsToPhysicalAsset { get; set; } = new PhysicalAssetSegmentSpecificationCorrespondsToPhysicalAssetRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetSegmentSpecificationHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new PhysicalAssetSegmentSpecificationHierarchyScopeRelRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetSegmentSpecificationPhysicalLocationRelRelationshipCollection PhysicalLocationRel { get; set; } = new PhysicalAssetSegmentSpecificationPhysicalLocationRelRelationshipCollection();

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
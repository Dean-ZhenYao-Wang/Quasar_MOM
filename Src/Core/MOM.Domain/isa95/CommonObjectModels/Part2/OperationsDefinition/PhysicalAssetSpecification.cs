namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsDefinition
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.PhysicalAssetSpecification;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PhysicalAssetSpecification : BaseEntity, IEquatable<PhysicalAssetSpecification>
    {
        public PhysicalAssetSpecification()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:PhysicalAssetSpecification;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("physicalLocation")]
        public string? PhysicalLocation { get; set; }

        [JsonPropertyName("physicalLocationType")]
        public PhysicalAssetSpecificationPhysicalLocationType? PhysicalLocationType { get; set; }

        [JsonPropertyName("physicalAssetUse")]
        public string? PhysicalAssetUse { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual PhysicalAssetSpecificationIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new PhysicalAssetSpecificationIsMadeUpOfRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetSpecificationSpecifiesRelationshipCollection Specifies { get; set; } = new PhysicalAssetSpecificationSpecifiesRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetSpecificationHasPropertiesOfRelationshipCollection HasPropertiesOf { get; set; } = new PhysicalAssetSpecificationHasPropertiesOfRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationshipCollection CorrespondsToPhysicalAssetClass { get; set; } = new PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationshipCollection CorrespondsToPhysicalAsset { get; set; } = new PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetSpecificationHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new PhysicalAssetSpecificationHierarchyScopeRelRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetSpecificationPhysicalLocationRelRelationshipCollection PhysicalLocationRel { get; set; } = new PhysicalAssetSpecificationPhysicalLocationRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetSpecification);
        }

        public bool Equals(PhysicalAssetSpecification? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && PhysicalLocation == other.PhysicalLocation && PhysicalLocationType == other.PhysicalLocationType && PhysicalAssetUse == other.PhysicalAssetUse && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(PhysicalAssetSpecification? left, PhysicalAssetSpecification? right)
        {
            return EqualityComparer<PhysicalAssetSpecification?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetSpecification? left, PhysicalAssetSpecification? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), PhysicalLocation?.GetHashCode(), PhysicalLocationType?.GetHashCode(), PhysicalAssetUse?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}
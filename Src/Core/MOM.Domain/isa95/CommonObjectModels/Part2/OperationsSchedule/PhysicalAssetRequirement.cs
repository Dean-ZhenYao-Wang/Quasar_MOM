namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsSchedule
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.PhysicalAssetRequirement;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PhysicalAssetRequirement : BaseEntity, IEquatable<PhysicalAssetRequirement>
    {
        public PhysicalAssetRequirement()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:PhysicalAssetRequirement;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("physicalLocation")]
        public string? PhysicalLocation { get; set; }

        [JsonPropertyName("physicalLocationType")]
        public PhysicalAssetRequirementPhysicalLocationType? PhysicalLocationType { get; set; }

        [JsonPropertyName("physicalAssetUse")]
        public string? PhysicalAssetUse { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonPropertyName("equipmentLevel")]
        public PhysicalAssetRequirementEquipmentLevel? EquipmentLevel { get; set; }

        [JsonIgnore]
        public virtual PhysicalAssetRequirementIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new PhysicalAssetRequirementIsMadeUpOfRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetRequirementHasValuesOfRelationshipCollection HasValuesOf { get; set; } = new PhysicalAssetRequirementHasValuesOfRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetRequirementCorrespondsToPhysicalAssetClassRelationshipCollection CorrespondsToPhysicalAssetClass { get; set; } = new PhysicalAssetRequirementCorrespondsToPhysicalAssetClassRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetRequirementCorrespondsToPhysicalAssetRelationshipCollection CorrespondsToPhysicalAsset { get; set; } = new PhysicalAssetRequirementCorrespondsToPhysicalAssetRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetRequirementHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new PhysicalAssetRequirementHierarchyScopeRelRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetRequirementPhysicalLocationRelRelationshipCollection PhysicalLocationRel { get; set; } = new PhysicalAssetRequirementPhysicalLocationRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetRequirement);
        }

        public bool Equals(PhysicalAssetRequirement? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && PhysicalLocation == other.PhysicalLocation && PhysicalLocationType == other.PhysicalLocationType && PhysicalAssetUse == other.PhysicalAssetUse && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure && EquipmentLevel == other.EquipmentLevel;
        }

        public static bool operator ==(PhysicalAssetRequirement? left, PhysicalAssetRequirement? right)
        {
            return EqualityComparer<PhysicalAssetRequirement?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetRequirement? left, PhysicalAssetRequirement? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), PhysicalLocation?.GetHashCode(), PhysicalLocationType?.GetHashCode(), PhysicalAssetUse?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode(), EquipmentLevel?.GetHashCode());
        }
    }
}
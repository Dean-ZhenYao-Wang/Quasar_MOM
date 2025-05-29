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
public virtual List<PhysicalAssetRequirementIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<PhysicalAssetRequirementIsMadeUpOfRelationship>();

        [JsonIgnore]
public virtual List<PhysicalAssetRequirementHasValuesOfRelationship> HasValuesOf { get; set; } = new List<PhysicalAssetRequirementHasValuesOfRelationship>();

        [JsonIgnore]
public virtual List<PhysicalAssetRequirementCorrespondsToPhysicalAssetClassRelationship> CorrespondsToPhysicalAssetClass { get; set; } = new List<PhysicalAssetRequirementCorrespondsToPhysicalAssetClassRelationship>();

        [JsonIgnore]
public virtual List<PhysicalAssetRequirementCorrespondsToPhysicalAssetRelationship> CorrespondsToPhysicalAsset { get; set; } = new List<PhysicalAssetRequirementCorrespondsToPhysicalAssetRelationship>();

        [JsonIgnore]
public virtual List<PhysicalAssetRequirementHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<PhysicalAssetRequirementHierarchyScopeRelRelationship>();

        [JsonIgnore]
public virtual List<PhysicalAssetRequirementPhysicalLocationRelRelationship> PhysicalLocationRel { get; set; } = new List<PhysicalAssetRequirementPhysicalLocationRelRelationship>();

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
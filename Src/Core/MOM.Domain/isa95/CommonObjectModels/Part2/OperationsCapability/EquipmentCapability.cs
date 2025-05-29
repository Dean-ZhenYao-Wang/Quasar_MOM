namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsCapability
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.EquipmentCapability;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class EquipmentCapability : BaseEntity, IEquatable<EquipmentCapability>
    {
        public EquipmentCapability()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:EquipmentCapability;1";

        [JsonPropertyName("capabilityType")]
        public EquipmentCapabilityCapabilityType? CapabilityType { get; set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

        [JsonPropertyName("confidenceFactor")]
        public string? ConfidenceFactor { get; set; }

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("operationalLocation")]
        public string? OperationalLocation { get; set; }

        [JsonPropertyName("operationalLocationType")]
        public EquipmentCapabilityOperationalLocationType? OperationalLocationType { get; set; }

        [JsonPropertyName("equipmentUse")]
        public string? EquipmentUse { get; set; }

        [JsonPropertyName("startTime")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime? EndTime { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<EquipmentCapabilityIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<EquipmentCapabilityIsMadeUpOfRelationship>();

        [JsonIgnore]
public virtual List<EquipmentCapabilityHasValuesOfRelationship> HasValuesOf { get; set; } = new List<EquipmentCapabilityHasValuesOfRelationship>();

        [JsonIgnore]
public virtual List<EquipmentCapabilityCorrespondsToEquipmentClassRelationship> CorrespondsToEquipmentClass { get; set; } = new List<EquipmentCapabilityCorrespondsToEquipmentClassRelationship>();

        [JsonIgnore]
public virtual List<EquipmentCapabilityCorrespondsToEquipmentRelationship> CorrespondsToEquipment { get; set; } = new List<EquipmentCapabilityCorrespondsToEquipmentRelationship>();

        [JsonIgnore]
public virtual List<EquipmentCapabilityHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<EquipmentCapabilityHierarchyScopeRelRelationship>();

        [JsonIgnore]
public virtual List<EquipmentCapabilityOperationalLocationRelRelationship> OperationalLocationRel { get; set; } = new List<EquipmentCapabilityOperationalLocationRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentCapability);
        }

        public bool Equals(EquipmentCapability? other)
        {
            return other is not null && base.Equals(other) && CapabilityType == other.CapabilityType && Reason == other.Reason && ConfidenceFactor == other.ConfidenceFactor && HierarchyScope == other.HierarchyScope && OperationalLocation == other.OperationalLocation && OperationalLocationType == other.OperationalLocationType && EquipmentUse == other.EquipmentUse && StartTime == other.StartTime && EndTime == other.EndTime && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(EquipmentCapability? left, EquipmentCapability? right)
        {
            return EqualityComparer<EquipmentCapability?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentCapability? left, EquipmentCapability? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), CapabilityType?.GetHashCode(), Reason?.GetHashCode(), ConfidenceFactor?.GetHashCode(), HierarchyScope?.GetHashCode(), OperationalLocation?.GetHashCode(), OperationalLocationType?.GetHashCode(), EquipmentUse?.GetHashCode(), StartTime?.GetHashCode(), EndTime?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}
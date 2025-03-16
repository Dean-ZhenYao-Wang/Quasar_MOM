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
        public virtual EquipmentCapabilityIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new EquipmentCapabilityIsMadeUpOfRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentCapabilityHasValuesOfRelationshipCollection HasValuesOf { get; set; } = new EquipmentCapabilityHasValuesOfRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentCapabilityCorrespondsToEquipmentClassRelationshipCollection CorrespondsToEquipmentClass { get; set; } = new EquipmentCapabilityCorrespondsToEquipmentClassRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentCapabilityCorrespondsToEquipmentRelationshipCollection CorrespondsToEquipment { get; set; } = new EquipmentCapabilityCorrespondsToEquipmentRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentCapabilityHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new EquipmentCapabilityHierarchyScopeRelRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentCapabilityOperationalLocationRelRelationshipCollection OperationalLocationRel { get; set; } = new EquipmentCapabilityOperationalLocationRelRelationshipCollection();

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
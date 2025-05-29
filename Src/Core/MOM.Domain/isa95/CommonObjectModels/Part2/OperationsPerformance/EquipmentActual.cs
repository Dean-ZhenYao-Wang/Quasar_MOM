namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsPerformance
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.EquipmentActual;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class EquipmentActual : BaseEntity, IEquatable<EquipmentActual>
    {
        public EquipmentActual()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:EquipmentActual;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("operationalLocation")]
        public string? OperationalLocation { get; set; }

        [JsonPropertyName("operationalLocationType")]
        public EquipmentActualOperationalLocationType? OperationalLocationType { get; set; }

        [JsonPropertyName("equipmentUse")]
        public string? EquipmentUse { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<EquipmentActualIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<EquipmentActualIsMadeUpOfRelationship>();

        [JsonIgnore]
public virtual List<EquipmentActualHasValuesOfRelationship> HasValuesOf { get; set; } = new List<EquipmentActualHasValuesOfRelationship>();

        [JsonIgnore]
public virtual List<EquipmentActualCorrespondsToEquipmentClassRelationship> CorrespondsToEquipmentClass { get; set; } = new List<EquipmentActualCorrespondsToEquipmentClassRelationship>();

        [JsonIgnore]
public virtual List<EquipmentActualCorrespondsToEquipmentRelationship> CorrespondsToEquipment { get; set; } = new List<EquipmentActualCorrespondsToEquipmentRelationship>();

        [JsonIgnore]
public virtual List<EquipmentActualHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<EquipmentActualHierarchyScopeRelRelationship>();

        [JsonIgnore]
public virtual List<EquipmentActualOperationalLocationRelRelationship> OperationalLocationRel { get; set; } = new List<EquipmentActualOperationalLocationRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentActual);
        }

        public bool Equals(EquipmentActual? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && OperationalLocation == other.OperationalLocation && OperationalLocationType == other.OperationalLocationType && EquipmentUse == other.EquipmentUse && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure;
        }

        public static bool operator ==(EquipmentActual? left, EquipmentActual? right)
        {
            return EqualityComparer<EquipmentActual?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentActual? left, EquipmentActual? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), OperationalLocation?.GetHashCode(), OperationalLocationType?.GetHashCode(), EquipmentUse?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode());
        }
    }
}
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
        public virtual EquipmentActualIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new EquipmentActualIsMadeUpOfRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentActualHasValuesOfRelationshipCollection HasValuesOf { get; set; } = new EquipmentActualHasValuesOfRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentActualCorrespondsToEquipmentClassRelationshipCollection CorrespondsToEquipmentClass { get; set; } = new EquipmentActualCorrespondsToEquipmentClassRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentActualCorrespondsToEquipmentRelationshipCollection CorrespondsToEquipment { get; set; } = new EquipmentActualCorrespondsToEquipmentRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentActualHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new EquipmentActualHierarchyScopeRelRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentActualOperationalLocationRelRelationshipCollection OperationalLocationRel { get; set; } = new EquipmentActualOperationalLocationRelRelationshipCollection();

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
namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsSchedule
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.EquipmentRequirement;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class EquipmentRequirement : BaseEntity, IEquatable<EquipmentRequirement>
    {
        public EquipmentRequirement()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:EquipmentRequirement;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("operationalLocation")]
        public string? OperationalLocation { get; set; }

        [JsonPropertyName("operationalLocationType")]
        public EquipmentRequirementOperationalLocationType? OperationalLocationType { get; set; }

        [JsonPropertyName("equipmentUse")]
        public string? EquipmentUse { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonPropertyName("equipmentLevel")]
        public EquipmentRequirementEquipmentLevel? EquipmentLevel { get; set; }

        [JsonIgnore]
        public virtual EquipmentRequirementIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new EquipmentRequirementIsMadeUpOfRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentRequirementHasValuesOfRelationshipCollection HasValuesOf { get; set; } = new EquipmentRequirementHasValuesOfRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentRequirementCorrespondsToEquipmentClassRelationshipCollection CorrespondsToEquipmentClass { get; set; } = new EquipmentRequirementCorrespondsToEquipmentClassRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentRequirementCorrespondsToEquipmentRelationshipCollection CorrespondsToEquipment { get; set; } = new EquipmentRequirementCorrespondsToEquipmentRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentRequirementHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new EquipmentRequirementHierarchyScopeRelRelationshipCollection();

        [JsonIgnore]
        public virtual EquipmentRequirementOperationalLocationRelRelationshipCollection OperationalLocationRel { get; set; } = new EquipmentRequirementOperationalLocationRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentRequirement);
        }

        public bool Equals(EquipmentRequirement? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && OperationalLocation == other.OperationalLocation && OperationalLocationType == other.OperationalLocationType && EquipmentUse == other.EquipmentUse && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure && EquipmentLevel == other.EquipmentLevel;
        }

        public static bool operator ==(EquipmentRequirement? left, EquipmentRequirement? right)
        {
            return EqualityComparer<EquipmentRequirement?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentRequirement? left, EquipmentRequirement? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), OperationalLocation?.GetHashCode(), OperationalLocationType?.GetHashCode(), EquipmentUse?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode(), EquipmentLevel?.GetHashCode());
        }
    }
}
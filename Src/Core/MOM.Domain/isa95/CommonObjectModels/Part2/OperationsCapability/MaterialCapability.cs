namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsCapability
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.MaterialCapability;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class MaterialCapability : BaseEntity, IEquatable<MaterialCapability>
    {
        public MaterialCapability()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:MaterialCapability;1";

        [JsonPropertyName("capabilityType")]
        public MaterialCapabilityCapabilityType? CapabilityType { get; set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

        [JsonPropertyName("confidenceFactor")]
        public string? ConfidenceFactor { get; set; }

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("storageLocation")]
        public string? StorageLocation { get; set; }

        [JsonPropertyName("storageLocationType")]
        public MaterialCapabilityStorageLocationType? StorageLocationType { get; set; }

        [JsonPropertyName("materialUse")]
        public MaterialCapabilityMaterialUse? MaterialUse { get; set; }

        [JsonPropertyName("startTime")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime? EndTime { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("quantityUnitOfMeasure")]
        public string? QuantityUnitOfMeasure { get; set; }

        [JsonPropertyName("assemblyType")]
        public MaterialCapabilityAssemblyType? AssemblyType { get; set; }

        [JsonPropertyName("assemblyRelationship")]
        public MaterialCapabilityAssemblyRelationship? AssemblyRelationship { get; set; }

        /// <summary>
        /// 组合关系
        /// </summary>
        [JsonIgnore]
        public virtual MaterialCapabilityIsAssembledFromRelationshipCollection IsAssembledFrom { get; set; } = new MaterialCapabilityIsAssembledFromRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialCapabilityHasValuesOfRelationshipCollection HasValuesOf { get; set; } = new MaterialCapabilityHasValuesOfRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialCapabilityCorrespondsToClassRelationshipCollection CorrespondsToClass { get; set; } = new MaterialCapabilityCorrespondsToClassRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialCapabilityCorrespondsToDefinitionRelationshipCollection CorrespondsToDefinition { get; set; } = new MaterialCapabilityCorrespondsToDefinitionRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialCapabilityCorrespondsToLotRelationshipCollection CorrespondsToLot { get; set; } = new MaterialCapabilityCorrespondsToLotRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialCapabilityCorrespondsToSublotRelationshipCollection CorrespondsToSublot { get; set; } = new MaterialCapabilityCorrespondsToSublotRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialCapabilityHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new MaterialCapabilityHierarchyScopeRelRelationshipCollection();

        [JsonIgnore]
        public virtual MaterialCapabilityStorageLocationRelRelationshipCollection StorageLocationRel { get; set; } = new MaterialCapabilityStorageLocationRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as MaterialCapability);
        }

        public bool Equals(MaterialCapability? other)
        {
            return other is not null && base.Equals(other) && CapabilityType == other.CapabilityType && Reason == other.Reason && ConfidenceFactor == other.ConfidenceFactor && HierarchyScope == other.HierarchyScope && StorageLocation == other.StorageLocation && StorageLocationType == other.StorageLocationType && MaterialUse == other.MaterialUse && StartTime == other.StartTime && EndTime == other.EndTime && Quantity == other.Quantity && QuantityUnitOfMeasure == other.QuantityUnitOfMeasure && AssemblyType == other.AssemblyType && AssemblyRelationship == other.AssemblyRelationship;
        }

        public static bool operator ==(MaterialCapability? left, MaterialCapability? right)
        {
            return EqualityComparer<MaterialCapability?>.Default.Equals(left, right);
        }

        public static bool operator !=(MaterialCapability? left, MaterialCapability? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), CapabilityType?.GetHashCode(), Reason?.GetHashCode(), ConfidenceFactor?.GetHashCode(), HierarchyScope?.GetHashCode(), StorageLocation?.GetHashCode(), StorageLocationType?.GetHashCode(), MaterialUse?.GetHashCode(), StartTime?.GetHashCode(), EndTime?.GetHashCode(), Quantity?.GetHashCode(), QuantityUnitOfMeasure?.GetHashCode(), AssemblyType?.GetHashCode(), AssemblyRelationship?.GetHashCode());
        }
    }
}
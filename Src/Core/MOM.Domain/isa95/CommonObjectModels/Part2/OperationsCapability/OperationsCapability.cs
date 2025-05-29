namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsCapability
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.OperationsCapability;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class OperationsCapability : BaseEntity, IEquatable<OperationsCapability>
    {
        public OperationsCapability()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:OperationsCapability;1";

        [JsonPropertyName("operationsType")]
        public OperationsCapabilityOperationsType? OperationsType { get; set; }

        [JsonPropertyName("capabilityType")]
        public OperationsCapabilityCapabilityType? CapabilityType { get; set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

        [JsonPropertyName("confidenceFactor")]
        public string? ConfidenceFactor { get; set; }

        [JsonPropertyName("startTime")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime? EndTime { get; set; }

        [JsonPropertyName("publishedDate")]
        public DateTime? PublishedDate { get; set; }

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonIgnore]
        public virtual List<OperationsCapabilityIsACollectionOfProcessRelationship> IsACollectionOfProcess { get; set; } = new List<OperationsCapabilityIsACollectionOfProcessRelationship>();

        [JsonIgnore]
        public virtual List<OperationsCapabilityIsACollectionOfOperationsRelationship> IsACollectionOfOperations { get; set; } = new List<OperationsCapabilityIsACollectionOfOperationsRelationship>();

        [JsonIgnore]
        public virtual List<OperationsCapabilityIsACollectionOfPersonnelRelationship> IsACollectionOfPersonnel { get; set; } = new List<OperationsCapabilityIsACollectionOfPersonnelRelationship>();

        [JsonIgnore]
        public virtual List<OperationsCapabilityIsACollectionOfEquipmentRelationship> IsACollectionOfEquipment { get; set; } = new List<OperationsCapabilityIsACollectionOfEquipmentRelationship>();

        [JsonIgnore]
        public virtual List<OperationsCapabilityIsACollectionOfPhysicalAssetRelationship> IsACollectionOfPhysicalAsset { get; set; } = new List<OperationsCapabilityIsACollectionOfPhysicalAssetRelationship>();

        [JsonIgnore]
        public virtual List<OperationsCapabilityIsACollectionOfMaterialRelationship> IsACollectionOfMaterial { get; set; } = new List<OperationsCapabilityIsACollectionOfMaterialRelationship>();

        [JsonIgnore]
        public virtual OperationsCapabilityHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new OperationsCapabilityHierarchyScopeRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsCapability);
        }

        public bool Equals(OperationsCapability? other)
        {
            return other is not null && base.Equals(other) && OperationsType == other.OperationsType && CapabilityType == other.CapabilityType && Reason == other.Reason && ConfidenceFactor == other.ConfidenceFactor && StartTime == other.StartTime && EndTime == other.EndTime && PublishedDate == other.PublishedDate && HierarchyScope == other.HierarchyScope;
        }

        public static bool operator ==(OperationsCapability? left, OperationsCapability? right)
        {
            return EqualityComparer<OperationsCapability?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsCapability? left, OperationsCapability? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), OperationsType?.GetHashCode(), CapabilityType?.GetHashCode(), Reason?.GetHashCode(), ConfidenceFactor?.GetHashCode(), StartTime?.GetHashCode(), EndTime?.GetHashCode(), PublishedDate?.GetHashCode(), HierarchyScope?.GetHashCode());
        }
    }
}
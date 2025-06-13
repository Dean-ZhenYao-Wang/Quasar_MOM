namespace MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.EquipmentAssetMapping;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class EquipmentAssetMapping : BaseEntity, IEquatable<EquipmentAssetMapping>
    {
        public EquipmentAssetMapping()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:EquipmentAssetMapping;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("startTime")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime? EndTime { get; set; }

        [JsonIgnore]
        public virtual List<EquipmentAssetMappingRecordsUseOfEquipmentRelationship> RecordsUseOfEquipment { get; set; } = new List<EquipmentAssetMappingRecordsUseOfEquipmentRelationship>();

        [JsonIgnore]
        public virtual List<EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship> RecordsUseOfPhysicalAsset { get; set; } = new List<EquipmentAssetMappingRecordsUseOfPhysicalAssetRelationship>();

        [JsonIgnore]
        public virtual List<EquipmentAssetMappingHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<EquipmentAssetMappingHierarchyScopeRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentAssetMapping);
        }

        public bool Equals(EquipmentAssetMapping? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && StartTime == other.StartTime && EndTime == other.EndTime;
        }

        public static bool operator ==(EquipmentAssetMapping? left, EquipmentAssetMapping? right)
        {
            return EqualityComparer<EquipmentAssetMapping?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentAssetMapping? left, EquipmentAssetMapping? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), StartTime?.GetHashCode(), EndTime?.GetHashCode());
        }
    }
}
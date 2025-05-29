namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsSchedule
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.SegmentRequirement;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class SegmentRequirement : BaseEntity, IEquatable<SegmentRequirement>
    {
        public SegmentRequirement()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:SegmentRequirement;1";

        [JsonPropertyName("operationsType")]
        public SegmentRequirementOperationsType? OperationsType { get; set; }

        [JsonPropertyName("earliestStartTime")]
        public DateTime? EarliestStartTime { get; set; }

        [JsonPropertyName("latestEndTime")]
        public DateTime? LatestEndTime { get; set; }

        [JsonPropertyName("duration")]
        public string? Duration { get; set; }

        [JsonPropertyName("durationUnitOfMeasure")]
        public string? DurationUnitOfMeasure { get; set; }

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("segmentState")]
        public SegmentRequirementSegmentState? SegmentState { get; set; }

        [JsonIgnore]
public virtual List<SegmentRequirementCorrespondsToDefinitionRelationship> CorrespondsToDefinition { get; set; } = new List<SegmentRequirementCorrespondsToDefinitionRelationship>();

        [JsonIgnore]
public virtual List<SegmentRequirementCorrespondsToSegmentRelationship> CorrespondsToSegment { get; set; } = new List<SegmentRequirementCorrespondsToSegmentRelationship>();

        [JsonIgnore]
public virtual List<SegmentRequirementCorrespondsToAProcessSegmentRelationship> CorrespondsToAProcessSegment { get; set; } = new List<SegmentRequirementCorrespondsToAProcessSegmentRelationship>();

        [JsonIgnore]
public virtual List<SegmentRequirementIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<SegmentRequirementIsMadeUpOfRelationship>();

        [JsonIgnore]
public virtual List<SegmentRequirementContainsParameterRelationship> ContainsParameter { get; set; } = new List<SegmentRequirementContainsParameterRelationship>();

        [JsonIgnore]
public virtual List<SegmentRequirementContainsPersonnelRelationship> ContainsPersonnel { get; set; } = new List<SegmentRequirementContainsPersonnelRelationship>();

        [JsonIgnore]
public virtual List<SegmentRequirementContainsEquipmentRelationship> ContainsEquipment { get; set; } = new List<SegmentRequirementContainsEquipmentRelationship>();

        [JsonIgnore]
public virtual List<SegmentRequirementContainsPhysicalAssetRelationship> ContainsPhysicalAsset { get; set; } = new List<SegmentRequirementContainsPhysicalAssetRelationship>();

        [JsonIgnore]
public virtual List<SegmentRequirementContainsMaterialRelationship> ContainsMaterial { get; set; } = new List<SegmentRequirementContainsMaterialRelationship>();

        [JsonIgnore]
public virtual List<SegmentRequirementHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<SegmentRequirementHierarchyScopeRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentRequirement);
        }

        public bool Equals(SegmentRequirement? other)
        {
            return other is not null && base.Equals(other) && OperationsType == other.OperationsType && EarliestStartTime == other.EarliestStartTime && LatestEndTime == other.LatestEndTime && Duration == other.Duration && DurationUnitOfMeasure == other.DurationUnitOfMeasure && HierarchyScope == other.HierarchyScope && SegmentState == other.SegmentState;
        }

        public static bool operator ==(SegmentRequirement? left, SegmentRequirement? right)
        {
            return EqualityComparer<SegmentRequirement?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentRequirement? left, SegmentRequirement? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), OperationsType?.GetHashCode(), EarliestStartTime?.GetHashCode(), LatestEndTime?.GetHashCode(), Duration?.GetHashCode(), DurationUnitOfMeasure?.GetHashCode(), HierarchyScope?.GetHashCode(), SegmentState?.GetHashCode());
        }
    }
}
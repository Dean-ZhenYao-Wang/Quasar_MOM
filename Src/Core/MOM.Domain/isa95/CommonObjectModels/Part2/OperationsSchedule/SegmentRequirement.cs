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
        public virtual SegmentRequirementCorrespondsToDefinitionRelationshipCollection CorrespondsToDefinition { get; set; } = new SegmentRequirementCorrespondsToDefinitionRelationshipCollection();

        [JsonIgnore]
        public virtual SegmentRequirementCorrespondsToSegmentRelationshipCollection CorrespondsToSegment { get; set; } = new SegmentRequirementCorrespondsToSegmentRelationshipCollection();

        [JsonIgnore]
        public virtual SegmentRequirementCorrespondsToAProcessSegmentRelationshipCollection CorrespondsToAProcessSegment { get; set; } = new SegmentRequirementCorrespondsToAProcessSegmentRelationshipCollection();

        [JsonIgnore]
        public virtual SegmentRequirementIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new SegmentRequirementIsMadeUpOfRelationshipCollection();

        [JsonIgnore]
        public virtual SegmentRequirementContainsParameterRelationshipCollection ContainsParameter { get; set; } = new SegmentRequirementContainsParameterRelationshipCollection();

        [JsonIgnore]
        public virtual SegmentRequirementContainsPersonnelRelationshipCollection ContainsPersonnel { get; set; } = new SegmentRequirementContainsPersonnelRelationshipCollection();

        [JsonIgnore]
        public virtual SegmentRequirementContainsEquipmentRelationshipCollection ContainsEquipment { get; set; } = new SegmentRequirementContainsEquipmentRelationshipCollection();

        [JsonIgnore]
        public virtual SegmentRequirementContainsPhysicalAssetRelationshipCollection ContainsPhysicalAsset { get; set; } = new SegmentRequirementContainsPhysicalAssetRelationshipCollection();

        [JsonIgnore]
        public virtual SegmentRequirementContainsMaterialRelationshipCollection ContainsMaterial { get; set; } = new SegmentRequirementContainsMaterialRelationshipCollection();

        [JsonIgnore]
        public virtual SegmentRequirementHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new SegmentRequirementHierarchyScopeRelRelationshipCollection();

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
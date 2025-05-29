namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsPerformance
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.SegmentResponse;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class SegmentResponse : BaseEntity, IEquatable<SegmentResponse>
    {
        public SegmentResponse()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:SegmentResponse;1";

        [JsonPropertyName("operationsType")]
        public SegmentResponseOperationsType? OperationsType { get; set; }

        [JsonPropertyName("startTime")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime? EndTime { get; set; }

        [JsonPropertyName("postingDate")]
        public DateTime? PostingDate { get; set; }

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("segmentState")]
        public SegmentResponseSegmentState? SegmentState { get; set; }

        [JsonIgnore]
public virtual List<SegmentResponseCorrespondsToDefinitionRelationship> CorrespondsToDefinition { get; set; } = new List<SegmentResponseCorrespondsToDefinitionRelationship>();

        [JsonIgnore]
public virtual List<SegmentResponseCorrespondsToSegmentRelationship> CorrespondsToSegment { get; set; } = new List<SegmentResponseCorrespondsToSegmentRelationship>();

        [JsonIgnore]
public virtual List<SegmentResponseCorrespondsToAProcessSegmentRelationship> CorrespondsToAProcessSegment { get; set; } = new List<SegmentResponseCorrespondsToAProcessSegmentRelationship>();

        [JsonIgnore]
public virtual List<SegmentResponseCorrespondsToRequirementRelationship> CorrespondsToRequirement { get; set; } = new List<SegmentResponseCorrespondsToRequirementRelationship>();

        [JsonIgnore]
public virtual List<SegmentResponseIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<SegmentResponseIsMadeUpOfRelationship>();

        [JsonIgnore]
public virtual List<SegmentResponseContainsDataRelationship> ContainsData { get; set; } = new List<SegmentResponseContainsDataRelationship>();

        [JsonIgnore]
public virtual List<SegmentResponseContainsPersonnelRelationship> ContainsPersonnel { get; set; } = new List<SegmentResponseContainsPersonnelRelationship>();

        [JsonIgnore]
public virtual List<SegmentResponseContainsEquipmentRelationship> ContainsEquipment { get; set; } = new List<SegmentResponseContainsEquipmentRelationship>();

        [JsonIgnore]
public virtual List<SegmentResponseContainsPhysicalAssetRelationship> ContainsPhysicalAsset { get; set; } = new List<SegmentResponseContainsPhysicalAssetRelationship>();

        [JsonIgnore]
public virtual List<SegmentResponseContainsMaterialRelationship> ContainsMaterial { get; set; } = new List<SegmentResponseContainsMaterialRelationship>();

        [JsonIgnore]
public virtual List<SegmentResponseHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<SegmentResponseHierarchyScopeRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentResponse);
        }

        public bool Equals(SegmentResponse? other)
        {
            return other is not null && base.Equals(other) && OperationsType == other.OperationsType && StartTime == other.StartTime && EndTime == other.EndTime && PostingDate == other.PostingDate && HierarchyScope == other.HierarchyScope && SegmentState == other.SegmentState;
        }

        public static bool operator ==(SegmentResponse? left, SegmentResponse? right)
        {
            return EqualityComparer<SegmentResponse?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentResponse? left, SegmentResponse? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), OperationsType?.GetHashCode(), StartTime?.GetHashCode(), EndTime?.GetHashCode(), PostingDate?.GetHashCode(), HierarchyScope?.GetHashCode(), SegmentState?.GetHashCode());
        }
    }
}
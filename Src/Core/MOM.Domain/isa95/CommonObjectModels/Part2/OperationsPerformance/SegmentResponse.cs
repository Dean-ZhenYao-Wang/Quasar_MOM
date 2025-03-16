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
        public virtual SegmentResponseCorrespondsToDefinitionRelationshipCollection CorrespondsToDefinition { get; set; } = new SegmentResponseCorrespondsToDefinitionRelationshipCollection();

        [JsonIgnore]
        public virtual SegmentResponseCorrespondsToSegmentRelationshipCollection CorrespondsToSegment { get; set; } = new SegmentResponseCorrespondsToSegmentRelationshipCollection();

        [JsonIgnore]
        public virtual SegmentResponseCorrespondsToAProcessSegmentRelationshipCollection CorrespondsToAProcessSegment { get; set; } = new SegmentResponseCorrespondsToAProcessSegmentRelationshipCollection();

        [JsonIgnore]
        public virtual SegmentResponseCorrespondsToRequirementRelationshipCollection CorrespondsToRequirement { get; set; } = new SegmentResponseCorrespondsToRequirementRelationshipCollection();

        [JsonIgnore]
        public virtual SegmentResponseIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new SegmentResponseIsMadeUpOfRelationshipCollection();

        [JsonIgnore]
        public virtual SegmentResponseContainsDataRelationshipCollection ContainsData { get; set; } = new SegmentResponseContainsDataRelationshipCollection();

        [JsonIgnore]
        public virtual SegmentResponseContainsPersonnelRelationshipCollection ContainsPersonnel { get; set; } = new SegmentResponseContainsPersonnelRelationshipCollection();

        [JsonIgnore]
        public virtual SegmentResponseContainsEquipmentRelationshipCollection ContainsEquipment { get; set; } = new SegmentResponseContainsEquipmentRelationshipCollection();

        [JsonIgnore]
        public virtual SegmentResponseContainsPhysicalAssetRelationshipCollection ContainsPhysicalAsset { get; set; } = new SegmentResponseContainsPhysicalAssetRelationshipCollection();

        [JsonIgnore]
        public virtual SegmentResponseContainsMaterialRelationshipCollection ContainsMaterial { get; set; } = new SegmentResponseContainsMaterialRelationshipCollection();

        [JsonIgnore]
        public virtual SegmentResponseHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new SegmentResponseHierarchyScopeRelRelationshipCollection();

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
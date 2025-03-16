namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsSchedule
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.RequestedSegmentResponse;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class RequestedSegmentResponse : BaseEntity, IEquatable<RequestedSegmentResponse>
    {
        public RequestedSegmentResponse()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:RequestedSegmentResponse;1";

        [JsonPropertyName("operationsType")]
        public RequestedSegmentResponseOperationsType? OperationsType { get; set; }

        [JsonPropertyName("earliestStartTime")]
        public DateTime? EarliestStartTime { get; set; }

        [JsonPropertyName("latestEndTime")]
        public DateTime? LatestEndTime { get; set; }

        [JsonPropertyName("postingDate")]
        public DateTime? PostingDate { get; set; }

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("segmentState")]
        public RequestedSegmentResponseSegmentState? SegmentState { get; set; }

        [JsonIgnore]
        public virtual RequestedSegmentResponseCorrespondsToDefinitionRelationshipCollection CorrespondsToDefinition { get; set; } = new RequestedSegmentResponseCorrespondsToDefinitionRelationshipCollection();

        [JsonIgnore]
        public virtual RequestedSegmentResponseCorrespondsToSegmentRelationshipCollection CorrespondsToSegment { get; set; } = new RequestedSegmentResponseCorrespondsToSegmentRelationshipCollection();

        [JsonIgnore]
        public virtual RequestedSegmentResponseCorrespondsToAProcessSegmentRelationshipCollection CorrespondsToAProcessSegment { get; set; } = new RequestedSegmentResponseCorrespondsToAProcessSegmentRelationshipCollection();

        [JsonIgnore]
        public virtual RequestedSegmentResponseCorrespondsToRequirementRelationshipCollection CorrespondsToRequirement { get; set; } = new RequestedSegmentResponseCorrespondsToRequirementRelationshipCollection();

        [JsonIgnore]
        public virtual RequestedSegmentResponseIsMadeUpOfRelationshipCollection IsMadeUpOf { get; set; } = new RequestedSegmentResponseIsMadeUpOfRelationshipCollection();

        [JsonIgnore]
        public virtual RequestedSegmentResponseContainsDataRelationshipCollection ContainsData { get; set; } = new RequestedSegmentResponseContainsDataRelationshipCollection();

        [JsonIgnore]
        public virtual RequestedSegmentResponseHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new RequestedSegmentResponseHierarchyScopeRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as RequestedSegmentResponse);
        }

        public bool Equals(RequestedSegmentResponse? other)
        {
            return other is not null && base.Equals(other) && OperationsType == other.OperationsType && EarliestStartTime == other.EarliestStartTime && LatestEndTime == other.LatestEndTime && PostingDate == other.PostingDate && HierarchyScope == other.HierarchyScope && SegmentState == other.SegmentState;
        }

        public static bool operator ==(RequestedSegmentResponse? left, RequestedSegmentResponse? right)
        {
            return EqualityComparer<RequestedSegmentResponse?>.Default.Equals(left, right);
        }

        public static bool operator !=(RequestedSegmentResponse? left, RequestedSegmentResponse? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), OperationsType?.GetHashCode(), EarliestStartTime?.GetHashCode(), LatestEndTime?.GetHashCode(), PostingDate?.GetHashCode(), HierarchyScope?.GetHashCode(), SegmentState?.GetHashCode());
        }
    }
}
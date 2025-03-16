namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsPerformance
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.OperationsResponse;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class OperationsResponse : BaseEntity, IEquatable<OperationsResponse>
    {
        public OperationsResponse()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:OperationsResponse;1";

        [JsonPropertyName("operationsType")]
        public OperationsResponseOperationsType? OperationsType { get; set; }

        [JsonPropertyName("startTime")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime? EndTime { get; set; }

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("responseState")]
        public OperationsResponseResponseState? ResponseState { get; set; }

        [JsonIgnore]
        public virtual OperationsResponseCorrespondsToRequestRelationshipCollection CorrespondsToRequest { get; set; } = new OperationsResponseCorrespondsToRequestRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsResponseCorrespondsToDefinitionRelationshipCollection CorrespondsToDefinition { get; set; } = new OperationsResponseCorrespondsToDefinitionRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsResponseCorrespondsToSegmentRelationshipCollection CorrespondsToSegment { get; set; } = new OperationsResponseCorrespondsToSegmentRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsResponseCorrespondsToRequirementRelationshipCollection CorrespondsToRequirement { get; set; } = new OperationsResponseCorrespondsToRequirementRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsResponseIsMadeUpOfRequirementRelationshipCollection IsMadeUpOfRequirement { get; set; } = new OperationsResponseIsMadeUpOfRequirementRelationshipCollection();

        [JsonIgnore]
        public virtual OperationsResponseHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new OperationsResponseHierarchyScopeRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsResponse);
        }

        public bool Equals(OperationsResponse? other)
        {
            return other is not null && base.Equals(other) && OperationsType == other.OperationsType && StartTime == other.StartTime && EndTime == other.EndTime && HierarchyScope == other.HierarchyScope && ResponseState == other.ResponseState;
        }

        public static bool operator ==(OperationsResponse? left, OperationsResponse? right)
        {
            return EqualityComparer<OperationsResponse?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsResponse? left, OperationsResponse? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), OperationsType?.GetHashCode(), StartTime?.GetHashCode(), EndTime?.GetHashCode(), HierarchyScope?.GetHashCode(), ResponseState?.GetHashCode());
        }
    }
}
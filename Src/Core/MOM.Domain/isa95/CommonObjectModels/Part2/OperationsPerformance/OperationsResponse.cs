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
public virtual List<OperationsResponseCorrespondsToRequestRelationship> CorrespondsToRequest { get; set; } = new List<OperationsResponseCorrespondsToRequestRelationship>();

        [JsonIgnore]
public virtual List<OperationsResponseCorrespondsToDefinitionRelationship> CorrespondsToDefinition { get; set; } = new List<OperationsResponseCorrespondsToDefinitionRelationship>();

        [JsonIgnore]
public virtual List<OperationsResponseCorrespondsToSegmentRelationship> CorrespondsToSegment { get; set; } = new List<OperationsResponseCorrespondsToSegmentRelationship>();

        [JsonIgnore]
public virtual List<OperationsResponseCorrespondsToRequirementRelationship> CorrespondsToRequirement { get; set; } = new List<OperationsResponseCorrespondsToRequirementRelationship>();

        [JsonIgnore]
public virtual List<OperationsResponseIsMadeUpOfRequirementRelationship> IsMadeUpOfRequirement { get; set; } = new List<OperationsResponseIsMadeUpOfRequirementRelationship>();

        [JsonIgnore]
public virtual List<OperationsResponseHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<OperationsResponseHierarchyScopeRelRelationship>();

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
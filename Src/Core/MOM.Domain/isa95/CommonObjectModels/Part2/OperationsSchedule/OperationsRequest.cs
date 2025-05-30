namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsSchedule
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.OperationsRequest;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class OperationsRequest : BaseEntity, IEquatable<OperationsRequest>
    {
        public OperationsRequest()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:OperationsRequest;1";

        [JsonPropertyName("operationsType")]
        public OperationsRequestOperationsType? OperationsType { get; set; }

        [JsonPropertyName("startTime")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime? EndTime { get; set; }

        [JsonPropertyName("priority")]
        public string? Priority { get; set; }

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("requestState")]
        public OperationsRequestRequestState? RequestState { get; set; }

        [JsonIgnore]
public virtual List<OperationsRequestIsMadeUpOfResponseRelationship> IsMadeUpOfResponse { get; set; } = new List<OperationsRequestIsMadeUpOfResponseRelationship>();

        [JsonIgnore]
public virtual List<OperationsRequestCorrespondsToDefinitionRelationship> CorrespondsToDefinition { get; set; } = new List<OperationsRequestCorrespondsToDefinitionRelationship>();

        [JsonIgnore]
public virtual List<OperationsRequestCorrespondsToSegmentRelationship> CorrespondsToSegment { get; set; } = new List<OperationsRequestCorrespondsToSegmentRelationship>();

        [JsonIgnore]
public virtual List<OperationsRequestIsMadeUpOfRequirementRelationship> IsMadeUpOfRequirement { get; set; } = new List<OperationsRequestIsMadeUpOfRequirementRelationship>();

        [JsonIgnore]
public virtual List<OperationsRequestHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<OperationsRequestHierarchyScopeRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsRequest);
        }

        public bool Equals(OperationsRequest? other)
        {
            return other is not null && base.Equals(other) && OperationsType == other.OperationsType && StartTime == other.StartTime && EndTime == other.EndTime && Priority == other.Priority && HierarchyScope == other.HierarchyScope && RequestState == other.RequestState;
        }

        public static bool operator ==(OperationsRequest? left, OperationsRequest? right)
        {
            return EqualityComparer<OperationsRequest?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsRequest? left, OperationsRequest? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), OperationsType?.GetHashCode(), StartTime?.GetHashCode(), EndTime?.GetHashCode(), Priority?.GetHashCode(), HierarchyScope?.GetHashCode(), RequestState?.GetHashCode());
        }
    }
}
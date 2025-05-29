namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsPerformance
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.OperationsPerformance;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class OperationsPerformance : BaseEntity, IEquatable<OperationsPerformance>
    {
        public OperationsPerformance()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:OperationsPerformance;1";

        [JsonPropertyName("operationsType")]
        public OperationsPerformanceOperationsType? OperationsType { get; set; }

        [JsonPropertyName("startTime")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime? EndTime { get; set; }

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("performanceState")]
        public OperationsPerformancePerformanceState? PerformanceState { get; set; }

        [JsonPropertyName("publishedDate")]
        public DateTime? PublishedDate { get; set; }

        [JsonIgnore]
public virtual List<OperationsPerformanceIsMadeUpOfRelationship> IsMadeUpOf { get; set; } = new List<OperationsPerformanceIsMadeUpOfRelationship>();

        [JsonIgnore]
public virtual List<OperationsPerformanceReferencesRelationship> References { get; set; } = new List<OperationsPerformanceReferencesRelationship>();

        [JsonIgnore]
public virtual List<OperationsPerformanceHierarchyScopeRelRelationship> HierarchyScopeRel { get; set; } = new List<OperationsPerformanceHierarchyScopeRelRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsPerformance);
        }

        public bool Equals(OperationsPerformance? other)
        {
            return other is not null && base.Equals(other) && OperationsType == other.OperationsType && StartTime == other.StartTime && EndTime == other.EndTime && HierarchyScope == other.HierarchyScope && PerformanceState == other.PerformanceState && PublishedDate == other.PublishedDate;
        }

        public static bool operator ==(OperationsPerformance? left, OperationsPerformance? right)
        {
            return EqualityComparer<OperationsPerformance?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsPerformance? left, OperationsPerformance? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), OperationsType?.GetHashCode(), StartTime?.GetHashCode(), EndTime?.GetHashCode(), HierarchyScope?.GetHashCode(), PerformanceState?.GetHashCode(), PublishedDate?.GetHashCode());
        }
    }
}
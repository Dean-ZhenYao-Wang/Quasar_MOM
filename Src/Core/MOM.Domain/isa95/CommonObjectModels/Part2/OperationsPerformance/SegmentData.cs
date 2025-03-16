namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsPerformance
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.SegmentData;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class SegmentData : BaseEntity, IEquatable<SegmentData>
    {
        public SegmentData()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:SegmentData;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual SegmentDataContainsRelationshipCollection Contains { get; set; } = new SegmentDataContainsRelationshipCollection();

        [JsonIgnore]
        public virtual SegmentDataHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new SegmentDataHierarchyScopeRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as SegmentData);
        }

        public bool Equals(SegmentData? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure;
        }

        public static bool operator ==(SegmentData? left, SegmentData? right)
        {
            return EqualityComparer<SegmentData?>.Default.Equals(left, right);
        }

        public static bool operator !=(SegmentData? left, SegmentData? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode());
        }
    }
}
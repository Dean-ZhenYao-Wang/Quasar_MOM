namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkPerformance
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.JobResponseData;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class JobResponseData : BaseEntity, IEquatable<JobResponseData>
    {
        public JobResponseData()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:JobResponseData;1";

        [JsonPropertyName("hierarchyScope")]
        public string? HierarchyScope { get; set; }

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual JobResponseDataContainsRelationshipCollection Contains { get; set; } = new JobResponseDataContainsRelationshipCollection();

        [JsonIgnore]
        public virtual JobResponseDataHierarchyScopeRelRelationshipCollection HierarchyScopeRel { get; set; } = new JobResponseDataHierarchyScopeRelRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as JobResponseData);
        }

        public bool Equals(JobResponseData? other)
        {
            return other is not null && base.Equals(other) && HierarchyScope == other.HierarchyScope && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure;
        }

        public static bool operator ==(JobResponseData? left, JobResponseData? right)
        {
            return EqualityComparer<JobResponseData?>.Default.Equals(left, right);
        }

        public static bool operator !=(JobResponseData? left, JobResponseData? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), HierarchyScope?.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode());
        }
    }
}
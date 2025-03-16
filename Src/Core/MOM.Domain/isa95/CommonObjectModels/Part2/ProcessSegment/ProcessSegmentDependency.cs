namespace MOM.Domain.isa95.CommonObjectModels.Part2.ProcessSegment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.ProcessSegmentDependency;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class ProcessSegmentDependency : BaseEntity, IEquatable<ProcessSegmentDependency>
    {
        public ProcessSegmentDependency()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:ProcessSegmentDependency;1";

        [JsonPropertyName("dependencyType")]
        public ProcessSegmentDependencyDependencyType? DependencyType { get; set; }

        [JsonPropertyName("dependencyFactor")]
        public string? DependencyFactor { get; set; }

        [JsonPropertyName("dependencyFactorUnitOfMeasure")]
        public string? DependencyFactorUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual ProcessSegmentDependencyProcessSegmentFromRelationshipCollection ProcessSegmentFrom { get; set; } = new ProcessSegmentDependencyProcessSegmentFromRelationshipCollection();

        [JsonIgnore]
        public virtual ProcessSegmentDependencyProcessSegmentToRelationshipCollection ProcessSegmentTo { get; set; } = new ProcessSegmentDependencyProcessSegmentToRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as ProcessSegmentDependency);
        }

        public bool Equals(ProcessSegmentDependency? other)
        {
            return other is not null && base.Equals(other) && DependencyType == other.DependencyType && DependencyFactor == other.DependencyFactor && DependencyFactorUnitOfMeasure == other.DependencyFactorUnitOfMeasure;
        }

        public static bool operator ==(ProcessSegmentDependency? left, ProcessSegmentDependency? right)
        {
            return EqualityComparer<ProcessSegmentDependency?>.Default.Equals(left, right);
        }

        public static bool operator !=(ProcessSegmentDependency? left, ProcessSegmentDependency? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), DependencyType?.GetHashCode(), DependencyFactor?.GetHashCode(), DependencyFactorUnitOfMeasure?.GetHashCode());
        }
    }
}
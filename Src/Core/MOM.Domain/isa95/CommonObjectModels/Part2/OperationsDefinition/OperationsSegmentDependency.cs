namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsDefinition
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.OperationsSegmentDependency;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class OperationsSegmentDependency : BaseEntity, IEquatable<OperationsSegmentDependency>
    {
        public OperationsSegmentDependency()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:OperationsSegmentDependency;1";

        [JsonPropertyName("dependencyType")]
        public OperationsSegmentDependencyDependencyType? DependencyType { get; set; }

        [JsonPropertyName("dependencyFactor")]
        public string? DependencyFactor { get; set; }

        [JsonPropertyName("dependencyFactorUnitOfMeasure")]
        public string? DependencyFactorUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<OperationsSegmentDependencyOperationsSegmentFromRelationship> OperationsSegmentFrom { get; set; } = new List<OperationsSegmentDependencyOperationsSegmentFromRelationship>();

        [JsonIgnore]
public virtual List<OperationsSegmentDependencyOperationsSegmentToRelationship> OperationsSegmentTo { get; set; } = new List<OperationsSegmentDependencyOperationsSegmentToRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as OperationsSegmentDependency);
        }

        public bool Equals(OperationsSegmentDependency? other)
        {
            return other is not null && base.Equals(other) && DependencyType == other.DependencyType && DependencyFactor == other.DependencyFactor && DependencyFactorUnitOfMeasure == other.DependencyFactorUnitOfMeasure;
        }

        public static bool operator ==(OperationsSegmentDependency? left, OperationsSegmentDependency? right)
        {
            return EqualityComparer<OperationsSegmentDependency?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperationsSegmentDependency? left, OperationsSegmentDependency? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), DependencyType?.GetHashCode(), DependencyFactor?.GetHashCode(), DependencyFactorUnitOfMeasure?.GetHashCode());
        }
    }
}
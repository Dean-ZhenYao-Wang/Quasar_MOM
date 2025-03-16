namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationConnection;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class WorkflowSpecificationConnection : BaseEntity, IEquatable<WorkflowSpecificationConnection>
    {
        public WorkflowSpecificationConnection()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkflowSpecificationConnection;1";

        [JsonPropertyName("dependencyType")]
        public WorkflowSpecificationConnectionDependencyType? DependencyType { get; set; }

        [JsonPropertyName("dependencyFactor")]
        public string? DependencyFactor { get; set; }

        [JsonPropertyName("dependencyFactorUnitOfMeasure")]
        public string? DependencyFactorUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual WorkflowSpecificationConnectionDefinedByRelationshipCollection DefinedBy { get; set; } = new WorkflowSpecificationConnectionDefinedByRelationshipCollection();

        [JsonIgnore]
        public virtual WorkflowSpecificationConnectionHasPropertiesOfRelationshipCollection HasPropertiesOf { get; set; } = new WorkflowSpecificationConnectionHasPropertiesOfRelationshipCollection();

        [JsonIgnore]
        public virtual WorkflowSpecificationConnectionConnectsToRelationshipCollection ConnectsTo { get; set; } = new WorkflowSpecificationConnectionConnectsToRelationshipCollection();

        [JsonIgnore]
        public virtual WorkflowSpecificationConnectionConnectsFromRelationshipCollection ConnectsFrom { get; set; } = new WorkflowSpecificationConnectionConnectsFromRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationConnection);
        }

        public bool Equals(WorkflowSpecificationConnection? other)
        {
            return other is not null && base.Equals(other) && DependencyType == other.DependencyType && DependencyFactor == other.DependencyFactor && DependencyFactorUnitOfMeasure == other.DependencyFactorUnitOfMeasure;
        }

        public static bool operator ==(WorkflowSpecificationConnection? left, WorkflowSpecificationConnection? right)
        {
            return EqualityComparer<WorkflowSpecificationConnection?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationConnection? left, WorkflowSpecificationConnection? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), DependencyType?.GetHashCode(), DependencyFactor?.GetHashCode(), DependencyFactorUnitOfMeasure?.GetHashCode());
        }
    }
}
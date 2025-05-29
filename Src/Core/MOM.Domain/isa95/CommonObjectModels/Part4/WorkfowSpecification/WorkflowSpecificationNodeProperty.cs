namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationNodeProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class WorkflowSpecificationNodeProperty : BaseEntity, IEquatable<WorkflowSpecificationNodeProperty>
    {
        public WorkflowSpecificationNodeProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkflowSpecificationNodeProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<WorkflowSpecificationNodePropertyContainsRelationship> Contains { get; set; } = new List<WorkflowSpecificationNodePropertyContainsRelationship>();

        [JsonIgnore]
public virtual List<WorkflowSpecificationNodePropertyMapsToRelationship> MapsTo { get; set; } = new List<WorkflowSpecificationNodePropertyMapsToRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationNodeProperty);
        }

        public bool Equals(WorkflowSpecificationNodeProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure;
        }

        public static bool operator ==(WorkflowSpecificationNodeProperty? left, WorkflowSpecificationNodeProperty? right)
        {
            return EqualityComparer<WorkflowSpecificationNodeProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationNodeProperty? left, WorkflowSpecificationNodeProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode());
        }
    }
}
namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class WorkflowSpecificationProperty : BaseEntity, IEquatable<WorkflowSpecificationProperty>
    {
        public WorkflowSpecificationProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkflowSpecificationProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual WorkflowSpecificationPropertyContainsRelationshipCollection Contains { get; set; } = new WorkflowSpecificationPropertyContainsRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationProperty);
        }

        public bool Equals(WorkflowSpecificationProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure;
        }

        public static bool operator ==(WorkflowSpecificationProperty? left, WorkflowSpecificationProperty? right)
        {
            return EqualityComparer<WorkflowSpecificationProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationProperty? left, WorkflowSpecificationProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode());
        }
    }
}
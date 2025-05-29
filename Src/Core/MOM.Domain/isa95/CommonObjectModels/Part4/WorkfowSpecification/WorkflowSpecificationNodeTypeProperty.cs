namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationNodeTypeProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class WorkflowSpecificationNodeTypeProperty : BaseEntity, IEquatable<WorkflowSpecificationNodeTypeProperty>
    {
        public WorkflowSpecificationNodeTypeProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkflowSpecificationNodeTypeProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<WorkflowSpecificationNodeTypePropertyContainsRelationship> Contains { get; set; } = new List<WorkflowSpecificationNodeTypePropertyContainsRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationNodeTypeProperty);
        }

        public bool Equals(WorkflowSpecificationNodeTypeProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure;
        }

        public static bool operator ==(WorkflowSpecificationNodeTypeProperty? left, WorkflowSpecificationNodeTypeProperty? right)
        {
            return EqualityComparer<WorkflowSpecificationNodeTypeProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationNodeTypeProperty? left, WorkflowSpecificationNodeTypeProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode());
        }
    }
}
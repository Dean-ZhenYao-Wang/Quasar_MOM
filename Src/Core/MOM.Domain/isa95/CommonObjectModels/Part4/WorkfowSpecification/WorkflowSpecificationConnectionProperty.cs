namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationConnectionProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class WorkflowSpecificationConnectionProperty : BaseEntity, IEquatable<WorkflowSpecificationConnectionProperty>
    {
        public WorkflowSpecificationConnectionProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkflowSpecificationConnectionProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<WorkflowSpecificationConnectionPropertyContainsRelationship> Contains { get; set; } = new List<WorkflowSpecificationConnectionPropertyContainsRelationship>();

        [JsonIgnore]
public virtual List<WorkflowSpecificationConnectionPropertyMapsToRelationship> MapsTo { get; set; } = new List<WorkflowSpecificationConnectionPropertyMapsToRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationConnectionProperty);
        }

        public bool Equals(WorkflowSpecificationConnectionProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure;
        }

        public static bool operator ==(WorkflowSpecificationConnectionProperty? left, WorkflowSpecificationConnectionProperty? right)
        {
            return EqualityComparer<WorkflowSpecificationConnectionProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationConnectionProperty? left, WorkflowSpecificationConnectionProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode());
        }
    }
}
namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkfowSpecification
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.WorkflowSpecificationConnectionTypeProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class WorkflowSpecificationConnectionTypeProperty : BaseEntity, IEquatable<WorkflowSpecificationConnectionTypeProperty>
    {
        public WorkflowSpecificationConnectionTypeProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkflowSpecificationConnectionTypeProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual WorkflowSpecificationConnectionTypePropertyContainsRelationshipCollection Contains { get; set; } = new WorkflowSpecificationConnectionTypePropertyContainsRelationshipCollection();

        [JsonIgnore]
        public virtual WorkflowSpecificationConnectionTypePropertyMapsToRelationshipCollection MapsTo { get; set; } = new WorkflowSpecificationConnectionTypePropertyMapsToRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkflowSpecificationConnectionTypeProperty);
        }

        public bool Equals(WorkflowSpecificationConnectionTypeProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure;
        }

        public static bool operator ==(WorkflowSpecificationConnectionTypeProperty? left, WorkflowSpecificationConnectionTypeProperty? right)
        {
            return EqualityComparer<WorkflowSpecificationConnectionTypeProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkflowSpecificationConnectionTypeProperty? left, WorkflowSpecificationConnectionTypeProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode());
        }
    }
}
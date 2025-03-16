namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkAlert
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.WorkAlertProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class WorkAlertProperty : BaseEntity, IEquatable<WorkAlertProperty>
    {
        public WorkAlertProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkAlertProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual WorkAlertPropertyMapsToRelationshipCollection MapsTo { get; set; } = new WorkAlertPropertyMapsToRelationshipCollection();

        [JsonIgnore]
        public virtual WorkAlertPropertyContainsRelationshipCollection Contains { get; set; } = new WorkAlertPropertyContainsRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkAlertProperty);
        }

        public bool Equals(WorkAlertProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure;
        }

        public static bool operator ==(WorkAlertProperty? left, WorkAlertProperty? right)
        {
            return EqualityComparer<WorkAlertProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkAlertProperty? left, WorkAlertProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode());
        }
    }
}
namespace MOM.Domain.isa95.CommonObjectModels.Part4.WorkAlert
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.WorkAlertDefinitionProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class WorkAlertDefinitionProperty : BaseEntity, IEquatable<WorkAlertDefinitionProperty>
    {
        public WorkAlertDefinitionProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:WorkAlertDefinitionProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual WorkAlertDefinitionPropertyContainsRelationshipCollection Contains { get; set; } = new WorkAlertDefinitionPropertyContainsRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as WorkAlertDefinitionProperty);
        }

        public bool Equals(WorkAlertDefinitionProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure;
        }

        public static bool operator ==(WorkAlertDefinitionProperty? left, WorkAlertDefinitionProperty? right)
        {
            return EqualityComparer<WorkAlertDefinitionProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(WorkAlertDefinitionProperty? left, WorkAlertDefinitionProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode());
        }
    }
}
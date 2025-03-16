namespace MOM.Domain.isa95.CommonObjectModels.Part2.OperationsTest
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.PropertyMeasurement;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PropertyMeasurement : BaseEntity, IEquatable<PropertyMeasurement>
    {
        public PropertyMeasurement()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:PropertyMeasurement;1";

        [JsonPropertyName("measurementDate")]
        public DateTime? MeasurementDate { get; set; }

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonPropertyName("expiration")]
        public DateTime? Expiration { get; set; }

        [JsonIgnore]
        public virtual PropertyMeasurementRecordsMeasurementOfRelationshipCollection RecordsMeasurementOf { get; set; } = new PropertyMeasurementRecordsMeasurementOfRelationshipCollection();

        [JsonIgnore]
        public virtual PropertyMeasurementMeasuredWithMethodOfRelationshipCollection MeasuredWithMethodOf { get; set; } = new PropertyMeasurementMeasuredWithMethodOfRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as PropertyMeasurement);
        }

        public bool Equals(PropertyMeasurement? other)
        {
            return other is not null && base.Equals(other) && MeasurementDate == other.MeasurementDate && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure && Expiration == other.Expiration;
        }

        public static bool operator ==(PropertyMeasurement? left, PropertyMeasurement? right)
        {
            return EqualityComparer<PropertyMeasurement?>.Default.Equals(left, right);
        }

        public static bool operator !=(PropertyMeasurement? left, PropertyMeasurement? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), MeasurementDate?.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode(), Expiration?.GetHashCode());
        }
    }
}
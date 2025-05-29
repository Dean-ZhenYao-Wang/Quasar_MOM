namespace MOM.Domain.isa95.CommonObjectModels
{
    using MOM.Domain.Common;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public abstract partial class ResourceProperty : BaseEntity, IEquatable<ResourceProperty>
    {
        public ResourceProperty() : base()
        {
        }

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ResourceProperty);
        }

        public bool Equals(ResourceProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure;
        }

        public static bool operator ==(ResourceProperty? left, ResourceProperty? right)
        {
            return EqualityComparer<ResourceProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(ResourceProperty? left, ResourceProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode());
        }
    }
}
namespace MOM.Domain.isa95.CommonObjectModels
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public abstract partial class ResourceClassProperty : BaseEntity, IEquatable<ResourceClassProperty>
    {
        public ResourceClassProperty() : base()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:ResourceClassProperty;1";

        /// <summary>
        /// 定义属性的类型。
        /// </summary>
        [JsonPropertyName("propertyType")]
        public ResourceClassPropertyPropertyType PropertyType { get; set; }

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ResourceClassProperty);
        }

        public bool Equals(ResourceClassProperty? other)
        {
            return other is not null && base.Equals(other) && PropertyType == other.PropertyType && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure;
        }

        public static bool operator ==(ResourceClassProperty? left, ResourceClassProperty? right)
        {
            return EqualityComparer<ResourceClassProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(ResourceClassProperty? left, ResourceClassProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), PropertyType.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode());
        }
    }
}
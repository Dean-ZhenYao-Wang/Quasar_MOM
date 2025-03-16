namespace MOM.Domain.isa95.CommonObjectModels.Part4.ResourceRelationship
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.ResourceNetworkConnectionProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class ResourceNetworkConnectionProperty : BaseEntity, IEquatable<ResourceNetworkConnectionProperty>
    {
        public ResourceNetworkConnectionProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:ResourceNetworkConnectionProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual ResourceNetworkConnectionPropertyMapsToRelationshipCollection MapsTo { get; set; } = new ResourceNetworkConnectionPropertyMapsToRelationshipCollection();

        [JsonIgnore]
        public virtual ResourceNetworkConnectionPropertyContainsRelationshipCollection Contains { get; set; } = new ResourceNetworkConnectionPropertyContainsRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as ResourceNetworkConnectionProperty);
        }

        public bool Equals(ResourceNetworkConnectionProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure;
        }

        public static bool operator ==(ResourceNetworkConnectionProperty? left, ResourceNetworkConnectionProperty? right)
        {
            return EqualityComparer<ResourceNetworkConnectionProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(ResourceNetworkConnectionProperty? left, ResourceNetworkConnectionProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode());
        }
    }
}
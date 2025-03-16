namespace MOM.Domain.isa95.CommonObjectModels.Part4.ResourceRelationship
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.ResourceNetworkConnectionTypeProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class ResourceNetworkConnectionTypeProperty : BaseEntity, IEquatable<ResourceNetworkConnectionTypeProperty>
    {
        public ResourceNetworkConnectionTypeProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:ResourceNetworkConnectionTypeProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonIgnore]
        public virtual ResourceNetworkConnectionTypePropertyMapsToRelationshipCollection MapsTo { get; set; } = new ResourceNetworkConnectionTypePropertyMapsToRelationshipCollection();

        [JsonIgnore]
        public virtual ResourceNetworkConnectionTypePropertyContainsRelationshipCollection Contains { get; set; } = new ResourceNetworkConnectionTypePropertyContainsRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as ResourceNetworkConnectionTypeProperty);
        }

        public bool Equals(ResourceNetworkConnectionTypeProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure;
        }

        public static bool operator ==(ResourceNetworkConnectionTypeProperty? left, ResourceNetworkConnectionTypeProperty? right)
        {
            return EqualityComparer<ResourceNetworkConnectionTypeProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(ResourceNetworkConnectionTypeProperty? left, ResourceNetworkConnectionTypeProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode());
        }
    }
}
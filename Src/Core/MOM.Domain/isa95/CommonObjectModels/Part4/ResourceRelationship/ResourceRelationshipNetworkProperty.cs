namespace MOM.Domain.isa95.CommonObjectModels.Part4.ResourceRelationship
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.ResourceRelationshipNetworkProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class ResourceRelationshipNetworkProperty : BaseEntity, IEquatable<ResourceRelationshipNetworkProperty>
    {
        public ResourceRelationshipNetworkProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:ResourceRelationshipNetworkProperty;1";

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("valueUnitOfMeasure")]
        public string? ValueUnitOfMeasure { get; set; }

        [JsonIgnore]
public virtual List<ResourceRelationshipNetworkPropertyContainsRelationship> Contains { get; set; } = new List<ResourceRelationshipNetworkPropertyContainsRelationship>();

        public override bool Equals(object? obj)
        {
            return Equals(obj as ResourceRelationshipNetworkProperty);
        }

        public bool Equals(ResourceRelationshipNetworkProperty? other)
        {
            return other is not null && base.Equals(other) && Value == other.Value && ValueUnitOfMeasure == other.ValueUnitOfMeasure;
        }

        public static bool operator ==(ResourceRelationshipNetworkProperty? left, ResourceRelationshipNetworkProperty? right)
        {
            return EqualityComparer<ResourceRelationshipNetworkProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(ResourceRelationshipNetworkProperty? left, ResourceRelationshipNetworkProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Value?.GetHashCode(), ValueUnitOfMeasure?.GetHashCode());
        }
    }
}
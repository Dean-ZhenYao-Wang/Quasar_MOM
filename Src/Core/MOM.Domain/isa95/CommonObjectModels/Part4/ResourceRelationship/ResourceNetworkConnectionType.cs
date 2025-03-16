namespace MOM.Domain.isa95.CommonObjectModels.Part4.ResourceRelationship
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.ResourceNetworkConnectionType;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class ResourceNetworkConnectionType : BaseEntity, IEquatable<ResourceNetworkConnectionType>
    {
        public ResourceNetworkConnectionType()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:ResourceNetworkConnectionType;1";

        [JsonIgnore]
        public virtual ResourceNetworkConnectionTypeHasPropertiesOfRelationshipCollection HasPropertiesOf { get; set; } = new ResourceNetworkConnectionTypeHasPropertiesOfRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as ResourceNetworkConnectionType);
        }

        public bool Equals(ResourceNetworkConnectionType? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ResourceNetworkConnectionType? left, ResourceNetworkConnectionType? right)
        {
            return EqualityComparer<ResourceNetworkConnectionType?>.Default.Equals(left, right);
        }

        public static bool operator !=(ResourceNetworkConnectionType? left, ResourceNetworkConnectionType? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}
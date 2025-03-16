namespace MOM.Domain.isa95.CommonObjectModels.Part4.ResourceRelationship
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.ResourceNetworkConnection;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class ResourceNetworkConnection : BaseEntity, IEquatable<ResourceNetworkConnection>
    {
        public ResourceNetworkConnection()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:ResourceNetworkConnection;1";

        [JsonIgnore]
        public virtual ResourceNetworkConnectionDefinedByRelationshipCollection DefinedBy { get; set; } = new ResourceNetworkConnectionDefinedByRelationshipCollection();

        [JsonIgnore]
        public virtual ResourceNetworkConnectionConnectsToRelationshipCollection ConnectsTo { get; set; } = new ResourceNetworkConnectionConnectsToRelationshipCollection();

        [JsonIgnore]
        public virtual ResourceNetworkConnectionConnectsFromRelationshipCollection ConnectsFrom { get; set; } = new ResourceNetworkConnectionConnectsFromRelationshipCollection();

        [JsonIgnore]
        public virtual ResourceNetworkConnectionHasPropertiesOfRelationshipCollection HasPropertiesOf { get; set; } = new ResourceNetworkConnectionHasPropertiesOfRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as ResourceNetworkConnection);
        }

        public bool Equals(ResourceNetworkConnection? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ResourceNetworkConnection? left, ResourceNetworkConnection? right)
        {
            return EqualityComparer<ResourceNetworkConnection?>.Default.Equals(left, right);
        }

        public static bool operator !=(ResourceNetworkConnection? left, ResourceNetworkConnection? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}
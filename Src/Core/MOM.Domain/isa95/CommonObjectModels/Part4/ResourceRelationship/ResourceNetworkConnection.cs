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
public virtual List<ResourceNetworkConnectionDefinedByRelationship> DefinedBy { get; set; } = new List<ResourceNetworkConnectionDefinedByRelationship>();

        [JsonIgnore]
public virtual List<ResourceNetworkConnectionConnectsToRelationship> ConnectsTo { get; set; } = new List<ResourceNetworkConnectionConnectsToRelationship>();

        [JsonIgnore]
public virtual List<ResourceNetworkConnectionConnectsFromRelationship> ConnectsFrom { get; set; } = new List<ResourceNetworkConnectionConnectsFromRelationship>();

        [JsonIgnore]
public virtual List<ResourceNetworkConnectionHasPropertiesOfRelationship> HasPropertiesOf { get; set; } = new List<ResourceNetworkConnectionHasPropertiesOfRelationship>();

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
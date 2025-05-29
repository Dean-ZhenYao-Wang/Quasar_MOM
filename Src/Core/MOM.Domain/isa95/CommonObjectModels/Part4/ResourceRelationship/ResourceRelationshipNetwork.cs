namespace MOM.Domain.isa95.CommonObjectModels.Part4.ResourceRelationship
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.ResourceRelationshipNetwork;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class ResourceRelationshipNetwork : BaseEntity, IEquatable<ResourceRelationshipNetwork>
    {
        public ResourceRelationshipNetwork()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:ResourceRelationshipNetwork;1";

        [JsonPropertyName("relationshipType")]
        public ResourceRelationshipNetworkRelationshipType? RelationshipType { get; set; }

        [JsonPropertyName("relationshipForm")]
        public ResourceRelationshipNetworkRelationshipForm? RelationshipForm { get; set; }

        [JsonIgnore]
        public virtual new List<ResourceRelationshipNetworkIsACollectionOfRelationship> IsACollectionOf { get; set; } = new List<ResourceRelationshipNetworkIsACollectionOfRelationship>();
        [JsonIgnore]
        public virtual new List<ResourceRelationshipNetworkHasPropertiesOfRelationship> HasPropertiesOf { get; set; } = new List<ResourceRelationshipNetworkHasPropertiesOfRelationship> ();

        public override bool Equals(object? obj)
        {
            return Equals(obj as ResourceRelationshipNetwork);
        }

        public bool Equals(ResourceRelationshipNetwork? other)
        {
            return other is not null && base.Equals(other) && RelationshipType == other.RelationshipType && RelationshipForm == other.RelationshipForm;
        }

        public static bool operator ==(ResourceRelationshipNetwork? left, ResourceRelationshipNetwork? right)
        {
            return EqualityComparer<ResourceRelationshipNetwork?>.Default.Equals(left, right);
        }

        public static bool operator !=(ResourceRelationshipNetwork? left, ResourceRelationshipNetwork? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), RelationshipType?.GetHashCode(), RelationshipForm?.GetHashCode());
        }
    }
}
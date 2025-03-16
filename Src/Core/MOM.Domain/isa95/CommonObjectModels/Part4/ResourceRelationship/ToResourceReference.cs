namespace MOM.Domain.isa95.CommonObjectModels.Part4.ResourceRelationship
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.ToResourceReference;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class ToResourceReference : BaseEntity, IEquatable<ToResourceReference>
    {
        public ToResourceReference()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:ToResourceReference;1";

        [JsonPropertyName("resourceType")]
        public ToResourceReferenceResourceType? ResourceType { get; set; }

        [JsonIgnore]
        public virtual ToResourceReferenceHasPropertiesOfRelationshipCollection HasPropertiesOf { get; set; } = new ToResourceReferenceHasPropertiesOfRelationshipCollection();

        [JsonIgnore]
        public virtual ToResourceReferenceCorrespondsToResourceClassRelationshipCollection CorrespondsToResourceClass { get; set; } = new ToResourceReferenceCorrespondsToResourceClassRelationshipCollection();

        [JsonIgnore]
        public virtual ToResourceReferenceCorrespondsToResourceRelationshipCollection CorrespondsToResource { get; set; } = new ToResourceReferenceCorrespondsToResourceRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as ToResourceReference);
        }

        public bool Equals(ToResourceReference? other)
        {
            return other is not null && base.Equals(other) && ResourceType == other.ResourceType;
        }

        public static bool operator ==(ToResourceReference? left, ToResourceReference? right)
        {
            return EqualityComparer<ToResourceReference?>.Default.Equals(left, right);
        }

        public static bool operator !=(ToResourceReference? left, ToResourceReference? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), ResourceType?.GetHashCode());
        }
    }
}
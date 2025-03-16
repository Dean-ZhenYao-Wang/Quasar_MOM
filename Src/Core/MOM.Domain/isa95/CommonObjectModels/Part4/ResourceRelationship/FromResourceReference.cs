namespace MOM.Domain.isa95.CommonObjectModels.Part4.ResourceRelationship
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.EnumType;
    using MOM.Domain.Common.Relationship.isa95.FromResourceReference;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class FromResourceReference : BaseEntity, IEquatable<FromResourceReference>
    {
        public FromResourceReference()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:FromResourceReference;1";

        [JsonPropertyName("resourceType")]
        public FromResourceReferenceResourceType? ResourceType { get; set; }

        [JsonIgnore]
        public virtual FromResourceReferenceHasPropertiesOfRelationshipCollection HasPropertiesOf { get; set; } = new FromResourceReferenceHasPropertiesOfRelationshipCollection();

        [JsonIgnore]
        public virtual FromResourceReferenceCorrespondsToResourceClassRelationshipCollection CorrespondsToResourceClass { get; set; } = new FromResourceReferenceCorrespondsToResourceClassRelationshipCollection();

        [JsonIgnore]
        public virtual FromResourceReferenceCorrespondsToResourceRelationshipCollection CorrespondsToResource { get; set; } = new FromResourceReferenceCorrespondsToResourceRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as FromResourceReference);
        }

        public bool Equals(FromResourceReference? other)
        {
            return other is not null && base.Equals(other) && ResourceType == other.ResourceType;
        }

        public static bool operator ==(FromResourceReference? left, FromResourceReference? right)
        {
            return EqualityComparer<FromResourceReference?>.Default.Equals(left, right);
        }

        public static bool operator !=(FromResourceReference? left, FromResourceReference? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), ResourceType?.GetHashCode());
        }
    }
}
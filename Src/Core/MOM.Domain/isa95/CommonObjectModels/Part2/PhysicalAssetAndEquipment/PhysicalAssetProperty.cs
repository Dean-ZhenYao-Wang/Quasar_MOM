namespace MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment
{
    using MOM.Domain.Common;
    using MOM.Domain.Common.Relationship.isa95.PhysicalAssetProperty;
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PhysicalAssetProperty : ResourceProperty, IEquatable<PhysicalAssetProperty>
    {
        public PhysicalAssetProperty()
        {
        }

        [JsonIgnore]
        public new static string ModelId { get; } = "dtmi:digitaltwins:isa95:PhysicalAssetProperty;1";

        [JsonIgnore]
        public virtual PhysicalAssetPropertyContainsRelationshipCollection Contains { get; set; } = new PhysicalAssetPropertyContainsRelationshipCollection();

        [JsonIgnore]
        public virtual PhysicalAssetPropertyMapsToRelationshipCollection MapsTo { get; set; } = new PhysicalAssetPropertyMapsToRelationshipCollection();

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhysicalAssetProperty);
        }

        public bool Equals(PhysicalAssetProperty? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PhysicalAssetProperty? left, PhysicalAssetProperty? right)
        {
            return EqualityComparer<PhysicalAssetProperty?>.Default.Equals(left, right);
        }

        public static bool operator !=(PhysicalAssetProperty? left, PhysicalAssetProperty? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}